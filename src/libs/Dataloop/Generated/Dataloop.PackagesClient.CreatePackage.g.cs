
#nullable enable

namespace Dataloop
{
    public partial class PackagesClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_CreatePackageSecurityRequirement0 =
            new global::Dataloop.EndPointSecurityRequirement
            {
                Authorizations = new global::Dataloop.EndPointAuthorizationRequirement[]
                {                    new global::Dataloop.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_CreatePackageSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_CreatePackageSecurityRequirement0,
            };
        partial void PrepareCreatePackageArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Dataloop.APIPackage request);
        partial void PrepareCreatePackageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Dataloop.APIPackage request);
        partial void ProcessCreatePackageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePackageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create new package.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Push your local package to the UI.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # Project will be taken in the following hierarchy:<br/>
        /// # project(input) -&gt; project_id(input) -&gt; self.project(context) -&gt; checked out<br/>
        /// # <br/>
        /// # :param dtlpy.entities.project.Project project: optional - project entity to deploy to. default from context or checked-out<br/>
        /// # :param str project_id: optional - project id to deploy to. default from context or checked-out<br/>
        /// # :param str package_name: package name<br/>
        /// # :param str src_path: path to package codebase<br/>
        /// # :param dtlpy.entities.codebase.Codebase codebase: codebase object<br/>
        /// # :param list modules: list of modules PackageModules of the package<br/>
        /// # :param bool is_global: is package is global or local<br/>
        /// # :param bool checkout: checkout package to local dir<br/>
        /// # :param str revision_increment: optional - str - version bumping method - major/minor/patch - default = None<br/>
        /// # :param str version: semver version f the package<br/>
        /// # :param bool ignore_sanity_check: NOT RECOMMENDED - skip code sanity check before pushing<br/>
        /// # :param bool service_update: optional - bool - update the service<br/>
        /// # :param dict service_config : Service object as dict. Contains the spec of the default service to create.<br/>
        /// # :param list slots: optional - list of slots PackageSlot of the package<br/>
        /// # :param list requirements: requirements - list of package requirements<br/>
        /// # :param str package_type: default 'faas', options: 'app', 'ml<br/>
        /// # :param dict metadata: dictionary of system and user metadata<br/>
        /// # <br/>
        /// # :return: Package object<br/>
        /// # :rtype: dtlpy.entities.package.Package<br/>
        /// # <br/>
        /// # <br/>
        /// # project.packages.push(package_name='package_name',<br/>
        /// # modules=[module],<br/>
        /// # version='1.0.0',<br/>
        /// # src_path=os.getcwd()<br/>
        /// # )<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APIPackage> CreatePackageAsync(

            global::Dataloop.APIPackage request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatePackageArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreatePackageSecurityRequirements,
                operationName: "CreatePackageAsync");

            using var __timeoutCancellationTokenSource = global::Dataloop.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Dataloop.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Dataloop.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Dataloop.PathBuilder(
                                path: "/packages",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Dataloop.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Dataloop.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreatePackageRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Dataloop.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Dataloop.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePackage",
                                methodName: "CreatePackageAsync",
                                pathTemplate: "\"/packages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Dataloop.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Dataloop.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePackage",
                                methodName: "CreatePackageAsync",
                                pathTemplate: "\"/packages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Dataloop.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Dataloop.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Dataloop.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Dataloop.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePackage",
                                methodName: "CreatePackageAsync",
                                pathTemplate: "\"/packages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Dataloop.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreatePackageResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Dataloop.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Dataloop.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePackage",
                                methodName: "CreatePackageAsync",
                                pathTemplate: "\"/packages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Dataloop.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Dataloop.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePackage",
                                methodName: "CreatePackageAsync",
                                pathTemplate: "\"/packages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreatePackageResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Dataloop.APIPackage.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Dataloop.APIPackage.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create new package.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="version"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="updatedBy"></param>
        /// <param name="name"></param>
        /// <param name="global"></param>
        /// <param name="projectId"></param>
        /// <param name="codebase"></param>
        /// <param name="modules"></param>
        /// <param name="uiHooks"></param>
        /// <param name="slots"></param>
        /// <param name="serviceConfig"></param>
        /// <param name="type"></param>
        /// <param name="requirements"></param>
        /// <param name="metadata"></param>
        /// <param name="panels"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APIPackage> CreatePackageAsync(
            string id,
            string url,
            string version,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string creator,
            string updatedBy,
            string name,
            bool global,
            string projectId,
            global::Dataloop.Codebase codebase,
            global::System.Collections.Generic.IList<global::Dataloop.Module> modules,
            global::Dataloop.PackageType type,
            global::System.Collections.Generic.IList<global::Dataloop.UiHook>? uiHooks = default,
            global::System.Collections.Generic.IList<global::Dataloop.PiperUiSlot>? slots = default,
            global::Dataloop.ServiceConfig? serviceConfig = default,
            global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>? requirements = default,
            global::Dataloop.PackageMetadata? metadata = default,
            global::System.Collections.Generic.IList<global::Dataloop.Panel>? panels = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.APIPackage
            {
                Id = id,
                Url = url,
                Version = version,
                CreatedAt = createdAt,
                UpdatedAt = updatedAt,
                Creator = creator,
                UpdatedBy = updatedBy,
                Name = name,
                Global = global,
                ProjectId = projectId,
                Codebase = codebase,
                Modules = modules,
                UiHooks = uiHooks,
                Slots = slots,
                ServiceConfig = serviceConfig,
                Type = type,
                Requirements = requirements,
                Metadata = metadata,
                Panels = panels,
            };

            return await CreatePackageAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}