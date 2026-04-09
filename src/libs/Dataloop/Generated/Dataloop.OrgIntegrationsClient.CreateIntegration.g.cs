
#nullable enable

namespace Dataloop
{
    public partial class OrgIntegrationsClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_CreateIntegrationSecurityRequirement0 =
            new global::Dataloop.EndPointSecurityRequirement
            {
                Authorizations = new global::Dataloop.EndPointAuthorizationRequirement[]
                {                    new global::Dataloop.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_CreateIntegrationSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_CreateIntegrationSecurityRequirement0,
            };
        partial void PrepareCreateIntegrationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string orgId,
            global::Dataloop.CreateIntegrationRequest request);
        partial void PrepareCreateIntegrationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string orgId,
            global::Dataloop.CreateIntegrationRequest request);
        partial void ProcessCreateIntegrationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateIntegrationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a new Integration
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create an integration between an external storage and the organization.<br/>
        /// # <br/>
        /// # **Examples for options include**:<br/>
        /// # s3 - {key: "", secret: ""};<br/>
        /// # gcs - {key: "", secret: "", content: ""};<br/>
        /// # azureblob - {key: "", secret: "", clientId: "", tenantId: ""};<br/>
        /// # key_value - {key: "", value: ""}<br/>
        /// # aws-sts - {key: "", secret: "", roleArns: ""}<br/>
        /// # aws-cross - {}<br/>
        /// # gcp-cross - {}<br/>
        /// # gcp-workload-identity-federation - {"secret": "", "content": "{}", "clientId": ""}<br/>
        /// # private-registry (ECR) - can use generate_ecr_options to generate the options<br/>
        /// # private-registry (GAR) - use generate_gar_options to generate the options<br/>
        /// # private-registry (ACR) - use generate_azure_container_registry_options to generate the options<br/>
        /// # private-registry (DockerHub) - use generate_docker_hub_options to generate the options<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* in the organization.<br/>
        /// # <br/>
        /// # :param IntegrationType integrations_type: integrations type dl.IntegrationType<br/>
        /// # :param str name: integrations name<br/>
        /// # :param dict options: dict of storage secrets<br/>
        /// # :param dict metadata: metadata<br/>
        /// # :param str organization_id: organization id<br/>
        /// # :return: success<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # project.integrations.create(integrations_type=dl.IntegrationType.S3,<br/>
        /// # name='S3Integration',<br/>
        /// # options={key: "Access key ID", secret: "Secret access key"})<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APIIntegration> CreateIntegrationAsync(
            string orgId,

            global::Dataloop.CreateIntegrationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateIntegrationArguments(
                httpClient: HttpClient,
                orgId: ref orgId,
                request: request);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateIntegrationSecurityRequirements,
                operationName: "CreateIntegrationAsync");

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/orgs/{orgId}/integrations",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateIntegrationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                orgId: orgId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateIntegrationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateIntegrationResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.APIIntegration.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Dataloop.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Dataloop.APIIntegration.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Dataloop.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Create a new Integration
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="metadata"></param>
        /// <param name="options"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APIIntegration> CreateIntegrationAsync(
            string orgId,
            global::Dataloop.Dictionary options,
            string name,
            global::Dataloop.IntegrationType2 type,
            global::Dataloop.IKeyValueMetadata? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.CreateIntegrationRequest
            {
                Metadata = metadata,
                Options = options,
                Name = name,
                Type = type,
            };

            return await CreateIntegrationAsync(
                orgId: orgId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}