
#nullable enable

namespace Dataloop
{
    public partial class ServicesClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_CreateServiceSecurityRequirement0 =
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
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_CreateServiceSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_CreateServiceSecurityRequirement0,
            };
        partial void PrepareCreateServiceArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Dataloop.APIService request);
        partial void PrepareCreateServiceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Dataloop.APIService request);
        partial void ProcessCreateServiceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateServiceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create new package.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Deploy service.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # :param str service_name: name<br/>
        /// # :param dtlpy.entities.package.Package package: package entity<br/>
        /// # :param str bot: bot email<br/>
        /// # :param str revision: package revision of version<br/>
        /// # :param init_input: config to run at startup<br/>
        /// # :param dict runtime: runtime resources<br/>
        /// # :param str pod_type: pod type dl.InstanceCatalog<br/>
        /// # :param str sdk_version:  - optional - string - sdk version<br/>
        /// # :param str agent_versions: - dictionary - - optional -versions of sdk<br/>
        /// # :param bool verify: if true, verify the inputs<br/>
        /// # :param bool checkout: if true, checkout (switch) to service<br/>
        /// # :param str module_name: module name<br/>
        /// # :param str project_id: project id<br/>
        /// # :param str driver_id: driver id<br/>
        /// # :param Callable func: function to deploy<br/>
        /// # :param bool run_execution_as_process: if true, run execution as process<br/>
        /// # :param int execution_timeout: execution timeout in seconds<br/>
        /// # :param int drain_time: drain time in seconds<br/>
        /// # :param int max_attempts: maximum execution retries in-case of a service reset<br/>
        /// # :param str on_reset: what happens on reset<br/>
        /// # :param bool force: optional - if true, terminate old replicas immediately<br/>
        /// # :param list secrets: list of the integrations ids<br/>
        /// # :param list integrations: list of the integrations<br/>
        /// # :param bool active: if true, activate the service<br/>
        /// # :param kwargs: list of additional arguments<br/>
        /// # :return: Service object<br/>
        /// # :rtype: dtlpy.entities.service.Service<br/>
        /// # <br/>
        /// # <br/>
        /// # service = package.services.deploy(service_name=package_name,<br/>
        /// # execution_timeout=3 * 60 * 60,<br/>
        /// # module_name=module.name,<br/>
        /// # runtime=dl.KubernetesRuntime(<br/>
        /// # concurrency=10,<br/>
        /// # pod_type=dl.InstanceCatalog.REGULAR_S,<br/>
        /// # autoscaler=dl.KubernetesRabbitmqAutoscaler(<br/>
        /// # min_replicas=1,<br/>
        /// # max_replicas=20,<br/>
        /// # queue_length=20<br/>
        /// # )<br/>
        /// # )<br/>
        /// # )<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APIService> CreateServiceAsync(

            global::Dataloop.APIService request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateServiceArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateServiceSecurityRequirements,
                operationName: "CreateServiceAsync");

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: "/services",
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
            PrepareCreateServiceRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateServiceResponse(
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
                ProcessCreateServiceResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.APIService.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dataloop.APIService.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create new package.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="packageId"></param>
        /// <param name="appId"></param>
        /// <param name="packageRevision"></param>
        /// <param name="initParams"></param>
        /// <param name="runtime"></param>
        /// <param name="useUserJwt"></param>
        /// <param name="botUserName"></param>
        /// <param name="versions"></param>
        /// <param name="moduleName"></param>
        /// <param name="global"></param>
        /// <param name="active"></param>
        /// <param name="runExecutionAsProcess"></param>
        /// <param name="executionTimeout"></param>
        /// <param name="drainTime"></param>
        /// <param name="onReset"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="driverId"></param>
        /// <param name="version"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="secrets"></param>
        /// <param name="panels"></param>
        /// <param name="config"></param>
        /// <param name="type"></param>
        /// <param name="crashloop"></param>
        /// <param name="mode"></param>
        /// <param name="metadata"></param>
        /// <param name="updatedBy"></param>
        /// <param name="archive"></param>
        /// <param name="settings"></param>
        /// <param name="displayName"></param>
        /// <param name="app"></param>
        /// <param name="integrations"></param>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APIService> CreateServiceAsync(
            string id,
            string url,
            string packageId,
            object initParams,
            global::Dataloop.ServiceRuntime runtime,
            bool useUserJwt,
            string botUserName,
            global::Dataloop.ServiceVersions versions,
            string moduleName,
            bool runExecutionAsProcess,
            double executionTimeout,
            double drainTime,
            global::Dataloop.OnResetAction onReset,
            string name,
            string projectId,
            string driverId,
            string version,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string creator,
            string? appId = default,
            string? packageRevision = default,
            bool? global = default,
            bool? active = default,
            double? maxAttempts = default,
            global::System.Collections.Generic.IList<string>? secrets = default,
            global::System.Collections.Generic.IList<global::Dataloop.Panel>? panels = default,
            global::Dataloop.IServiceAppConfig? config = default,
            global::Dataloop.ServiceType? type = default,
            global::Dataloop.Crashloop? crashloop = default,
            global::Dataloop.ServiceMode? mode = default,
            global::Dataloop.ServiceMetadata? metadata = default,
            string? updatedBy = default,
            bool? archive = default,
            global::Dataloop.IServiceGeneralSettings? settings = default,
            string? displayName = default,
            global::Dataloop.IAppDefinition? app = default,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? integrations = default,
            string? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.APIService
            {
                Id = id,
                Url = url,
                PackageId = packageId,
                AppId = appId,
                PackageRevision = packageRevision,
                InitParams = initParams,
                Runtime = runtime,
                UseUserJwt = useUserJwt,
                BotUserName = botUserName,
                Versions = versions,
                ModuleName = moduleName,
                Global = global,
                Active = active,
                RunExecutionAsProcess = runExecutionAsProcess,
                ExecutionTimeout = executionTimeout,
                DrainTime = drainTime,
                OnReset = onReset,
                Name = name,
                ProjectId = projectId,
                DriverId = driverId,
                Version = version,
                CreatedAt = createdAt,
                UpdatedAt = updatedAt,
                Creator = creator,
                MaxAttempts = maxAttempts,
                Secrets = secrets,
                Panels = panels,
                Config = config,
                Type = type,
                Crashloop = crashloop,
                Mode = mode,
                Metadata = metadata,
                UpdatedBy = updatedBy,
                Archive = archive,
                Settings = settings,
                DisplayName = displayName,
                App = app,
                Integrations = integrations,
                OrgId = orgId,
            };

            return await CreateServiceAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}