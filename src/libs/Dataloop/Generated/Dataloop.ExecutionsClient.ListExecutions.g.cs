
#nullable enable

namespace Dataloop
{
    public partial class ExecutionsClient
    {
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
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListExecutionsResponse(
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
                ProcessListExecutionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.ExecutionsPage.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Dataloop.ExecutionsPage.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}