# CLAUDE.md -- Dataloop SDK

## Overview

Auto-generated C# SDK for [Dataloop AI](https://dataloop.ai/) -- enterprise AI data management, annotation, and ML pipeline platform.
OpenAPI spec from `https://gate.dataloop.ai/api/v1/swagger-file` (OpenAPI 3.0.0, 335 endpoints).

## Build & Test

```bash
dotnet build Dataloop.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

JWT Bearer token auth. API key from Dataloop console:

```csharp
var client = new DataloopClient(apiKey); // DATALOOP_API_KEY env var
```

## Key Files

- `src/libs/Dataloop/openapi.yaml` -- Source OpenAPI spec
- `src/libs/Dataloop/generate.sh` -- Spec fixes + autosdk generation
- `src/libs/Dataloop/Generated/` -- **Never edit** -- auto-generated code (3697 files)
- `src/libs/Dataloop/Extensions/DataloopClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Fixes in generate.sh

- Removes bad `default` values from `DatasetDeletionInformation` date-time fields (`"TimeProvider.now"`, `` "`now + 30 days`" ``)
- Wraps boolean request bodies in objects (compositions/pipelines uninstall endpoints)
- Changes `CompositionStatus` enum response to inline string (avoids `FromJson` generation issue)

## Sub-client Pattern

```csharp
var client = new DataloopClient(apiKey);

// Projects
client.Projects.GetMyProjectsAsync()         // List all projects
client.Projects.GetProjectAsync(projectId)    // Get project details
client.Projects.CreateProjectAsync(...)       // Create project
client.Projects.DeleteProjectAsync(projectId) // Delete project

// Datasets
client.Datasets.ListDatasetsAsync()           // List datasets
client.Datasets.GetDatasetByIdAsync(id)       // Get dataset
client.Datasets.CreateDatasetAsync(...)       // Create dataset
client.Datasets.CloneDatasetAsync(...)        // Clone dataset

// Items
client.Items.GetItemAsync(id)                 // Get item details
client.Items.EditItemAsync(id, ...)           // Edit item
client.Items.StreamItemAsync(id)              // Stream item content

// Annotation Tasks
client.Tasks.FindTasksAsync(...)              // Find/list tasks
client.Tasks.GetTaskAsync(id)                 // Get task details
client.Tasks.CreateTaskAsync(...)             // Create task

// Models (ML)
client.Models.*                               // ML model management

// Pipelines
client.Pipelines.*                            // Pipeline orchestration

// Annotations
client.Annotations.*                          // Annotation CRUD
client.DatasetItemAnnotations.*               // Dataset item annotations

// Organizations
client.Organizations.*                        // Organization management
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsListProjectsTool()` -- List all annotation projects
- `AsListDatasetsTool()` -- List datasets (optional project filter)
- `AsListTasksTool()` -- Find annotation tasks (optional project/status filter)
- `AsGetItemTool()` -- Get item details by ID
