
#nullable enable

namespace Dataloop
{
    public partial class ExecutionsClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_ListExecutionsSecurityRequirement0 =
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
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_ListExecutionsSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_ListExecutionsSecurityRequirement0,
            };
        partial void PrepareListExecutionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? projectsQuery,
            ref string? service,
            ref string? trigger,
            ref string? functionName,
            ref global::Dataloop.ExecutionsOrderByType? orderByType,
            ref global::Dataloop.ExecutionsOrderByDirection? orderByDirection,
            ref string? createdAfter,
            ref string? createdBefore,
            ref global::Dataloop.ExecutionStatusName? status,
            ref global::Dataloop.PackageResourceType? resourceType,
            ref string? resourceId,
            ref double? pageOffset,
            ref double? pageSize);
        partial void PrepareListExecutionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? projectsQuery,
            string? service,
            string? trigger,
            string? functionName,
            global::Dataloop.ExecutionsOrderByType? orderByType,
            global::Dataloop.ExecutionsOrderByDirection? orderByDirection,
            string? createdAfter,
            string? createdBefore,
            global::Dataloop.ExecutionStatusName? status,
            global::Dataloop.PackageResourceType? resourceType,
            string? resourceId,
            double? pageOffset,
            double? pageSize);
        partial void ProcessListExecutionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListExecutionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List service executions.
        /// </summary>
        /// <param name="projectsQuery"></param>
        /// <param name="service"></param>
        /// <param name="trigger"></param>
        /// <param name="functionName"></param>
        /// <param name="orderByType"></param>
        /// <param name="orderByDirection"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="status"></param>
        /// <param name="resourceType"></param>
        /// <param name="resourceId"></param>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.ExecutionsPage> ListExecutionsAsync(
            string? projectsQuery = default,
            string? service = default,
            string? trigger = default,
            string? functionName = default,
            global::Dataloop.ExecutionsOrderByType? orderByType = default,
            global::Dataloop.ExecutionsOrderByDirection? orderByDirection = default,
            string? createdAfter = default,
            string? createdBefore = default,
            global::Dataloop.ExecutionStatusName? status = default,
            global::Dataloop.PackageResourceType? resourceType = default,
            string? resourceId = default,
            double? pageOffset = default,
            double? pageSize = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListExecutionsArguments(
                httpClient: HttpClient,
                projectsQuery: ref projectsQuery,
                service: ref service,
                trigger: ref trigger,
                functionName: ref functionName,
                orderByType: ref orderByType,
                orderByDirection: ref orderByDirection,
                createdAfter: ref createdAfter,
                createdBefore: ref createdBefore,
                status: ref status,
                resourceType: ref resourceType,
                resourceId: ref resourceId,
                pageOffset: ref pageOffset,
                pageSize: ref pageSize);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListExecutionsSecurityRequirements,
                operationName: "ListExecutionsAsync");

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
                                path: "/executions",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("projectsQuery", projectsQuery)
                                .AddOptionalParameter("service", service)
                                .AddOptionalParameter("trigger", trigger)
                                .AddOptionalParameter("functionName", functionName)
                                .AddOptionalParameter("orderByType", orderByType?.ToValueString())
                                .AddOptionalParameter("orderByDirection", orderByDirection?.ToValueString())
                                .AddOptionalParameter("createdAfter", createdAfter)
                                .AddOptionalParameter("createdBefore", createdBefore)
                                .AddOptionalParameter("status", status?.ToValueString())
                                .AddOptionalParameter("resourceType", resourceType?.ToValueString())
                                .AddOptionalParameter("resourceId", resourceId)
                                .AddOptionalParameter("pageOffset", pageOffset?.ToString())
                                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Dataloop.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Dataloop.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListExecutionsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    projectsQuery: projectsQuery,
                    service: service,
                    trigger: trigger,
                    functionName: functionName,
                    orderByType: orderByType,
                    orderByDirection: orderByDirection,
                    createdAfter: createdAfter,
                    createdBefore: createdBefore,
                    status: status,
                    resourceType: resourceType,
                    resourceId: resourceId,
                    pageOffset: pageOffset,
                    pageSize: pageSize);

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
                                operationId: "ListExecutions",
                                methodName: "ListExecutionsAsync",
                                pathTemplate: "\"/executions\"",
                                httpMethod: "GET",
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
                                operationId: "ListExecutions",
                                methodName: "ListExecutionsAsync",
                                pathTemplate: "\"/executions\"",
                                httpMethod: "GET",
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
                                operationId: "ListExecutions",
                                methodName: "ListExecutionsAsync",
                                pathTemplate: "\"/executions\"",
                                httpMethod: "GET",
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
                ProcessListExecutionsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Dataloop.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Dataloop.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListExecutions",
                                methodName: "ListExecutionsAsync",
                                pathTemplate: "\"/executions\"",
                                httpMethod: "GET",
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
                                operationId: "ListExecutions",
                                methodName: "ListExecutionsAsync",
                                pathTemplate: "\"/executions\"",
                                httpMethod: "GET",
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
                                ProcessListExecutionsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Dataloop.ExecutionsPage.FromJson(__content, JsonSerializerContext) ??
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
                                        await global::Dataloop.ExecutionsPage.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}