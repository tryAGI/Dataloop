
#nullable enable

namespace Dataloop
{
    public partial class ServicesClient
    {
        partial void PrepareUpdateServiceArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref string? force,
            global::Dataloop.APIServicePatch request);
        partial void PrepareUpdateServiceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            string? force,
            global::Dataloop.APIServicePatch request);
        partial void ProcessUpdateServiceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateServiceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update service changes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update service changes to platform.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.service.Service service: Service entity<br/>
        /// # :param bool force: optional - terminate old replicas immediately<br/>
        /// # :return: Service entity<br/>
        /// # :rtype: dtlpy.entities.service.Service<br/>
        /// # <br/>
        /// # <br/>
        /// # service = package.services.update(service='service_entity')<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIService, string>> UpdateServiceAsync(
            string id,

            global::Dataloop.APIServicePatch request,
            string? force = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateServiceArguments(
                httpClient: HttpClient,
                id: ref id,
                force: ref force,
                request: request);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/services/{id}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("force", force) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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
            PrepareUpdateServiceRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                force: force,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateServiceResponse(
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
                ProcessUpdateServiceResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.AnyOf<global::Dataloop.APIService, string>.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dataloop.AnyOf<global::Dataloop.APIService, string>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Update service changes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="packageRevision"></param>
        /// <param name="initParams"></param>
        /// <param name="runtime"></param>
        /// <param name="useUserJwt"></param>
        /// <param name="versions"></param>
        /// <param name="moduleName"></param>
        /// <param name="global"></param>
        /// <param name="active"></param>
        /// <param name="runExecutionAsProcess"></param>
        /// <param name="executionTimeout"></param>
        /// <param name="drainTime"></param>
        /// <param name="onReset"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="version"></param>
        /// <param name="botUserName"></param>
        /// <param name="driverId"></param>
        /// <param name="secrets"></param>
        /// <param name="type"></param>
        /// <param name="mode"></param>
        /// <param name="metadata"></param>
        /// <param name="panels"></param>
        /// <param name="packageId"></param>
        /// <param name="packageName"></param>
        /// <param name="archive"></param>
        /// <param name="displayName"></param>
        /// <param name="app"></param>
        /// <param name="integrations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIService, string>> UpdateServiceAsync(
            string id,
            string? force = default,
            string? packageRevision = default,
            object? initParams = default,
            global::Dataloop.ServiceRuntime? runtime = default,
            bool? useUserJwt = default,
            global::Dataloop.ServiceVersions? versions = default,
            string? moduleName = default,
            bool? global = default,
            bool? active = default,
            bool? runExecutionAsProcess = default,
            double? executionTimeout = default,
            double? drainTime = default,
            string? onReset = default,
            double? maxAttempts = default,
            string? version = default,
            string? botUserName = default,
            string? driverId = default,
            global::System.Collections.Generic.IList<string>? secrets = default,
            global::Dataloop.ServiceType? type = default,
            global::Dataloop.ServiceMode? mode = default,
            global::Dataloop.ServiceMetadata? metadata = default,
            global::System.Collections.Generic.IList<global::Dataloop.Panel>? panels = default,
            string? packageId = default,
            string? packageName = default,
            bool? archive = default,
            string? displayName = default,
            global::Dataloop.IAppDefinition? app = default,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? integrations = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.APIServicePatch
            {
                PackageRevision = packageRevision,
                InitParams = initParams,
                Runtime = runtime,
                UseUserJwt = useUserJwt,
                Versions = versions,
                ModuleName = moduleName,
                Global = global,
                Active = active,
                RunExecutionAsProcess = runExecutionAsProcess,
                ExecutionTimeout = executionTimeout,
                DrainTime = drainTime,
                OnReset = onReset,
                MaxAttempts = maxAttempts,
                Version = version,
                BotUserName = botUserName,
                DriverId = driverId,
                Secrets = secrets,
                Type = type,
                Mode = mode,
                Metadata = metadata,
                Panels = panels,
                PackageId = packageId,
                PackageName = packageName,
                Archive = archive,
                DisplayName = displayName,
                App = app,
                Integrations = integrations,
            };

            return await UpdateServiceAsync(
                id: id,
                force: force,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}