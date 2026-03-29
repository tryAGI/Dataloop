dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://gate.dataloop.ai/api/v1/swagger-file

# Fix spec issues:
# 1. Remove bad default values from DatasetDeletionInformation date-time fields
# 2. Change boolean request bodies to nullable (object wrapper) for compositions/pipelines uninstall
# 3. Change CompositionStatus response from enum ref to inline string to avoid FromJson issue
python3 -c "
import json, sys

with open('openapi.yaml', 'r') as f:
    spec = json.load(f)

# Fix 1: Remove bad default values from DatasetDeletionInformation
schemas = spec.get('components', {}).get('schemas', {})
if 'DatasetDeletionInformation' in schemas:
    props = schemas['DatasetDeletionInformation'].get('properties', {})
    for field in ['markedForDeletionDate', 'targetDeleteDate']:
        if field in props and 'default' in props[field]:
            del props[field]['default']

# Fix 2: Change boolean request bodies to object wrapper
for path_key in list(spec.get('paths', {}).keys()):
    for method in list(spec['paths'][path_key].keys()):
        op = spec['paths'][path_key][method]
        rb = op.get('requestBody', {})
        content = rb.get('content', {}).get('application/json', {})
        schema = content.get('schema', {})
        if schema.get('type') == 'boolean':
            content['schema'] = {
                'type': 'object',
                'properties': {
                    'value': {
                        'type': 'boolean',
                        'description': schema.get('description', 'Boolean value')
                    }
                }
            }

# Fix 3: Change CompositionStatus response to inline string
for path_key in list(spec.get('paths', {}).keys()):
    if 'terminate' in path_key:
        for method in list(spec['paths'][path_key].keys()):
            op = spec['paths'][path_key][method]
            responses = op.get('responses', {})
            for code, resp in responses.items():
                content = resp.get('content', {}).get('application/json', {})
                schema = content.get('schema', {})
                if schema.get('\$ref', '').endswith('/CompositionStatus'):
                    content['schema'] = {'type': 'string', 'description': 'Composition status'}

with open('openapi.yaml', 'w') as f:
    json.dump(spec, f, indent=2)
"

autosdk generate openapi.yaml \
  --namespace Dataloop \
  --clientClassName DataloopClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations
