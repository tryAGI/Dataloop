
#nullable enable

namespace Dataloop
{
    public partial class AssignmentsClient
    {
        partial void PrepareFindAssignmentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? name,
            global::System.Collections.Generic.IList<string>? projects,
            ref string? annotator,
            ref string? status,
            ref double? pageOffset,
            ref double? pageSize,
            ref string? taskId,
            ref bool? active,
            ref bool? archive);
        partial void PrepareFindAssignmentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? name,
            global::System.Collections.Generic.IList<string>? projects,
            string? annotator,
            string? status,
            double? pageOffset,
            double? pageSize,
            string? taskId,
            bool? active,
            bool? archive);
        partial void ProcessFindAssignmentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFindAssignmentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Find assignments by query
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projects"></param>
        /// <param name="annotator"></param>
        /// <param name="status"></param>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="taskId"></param>
        /// <param name="active"></param>
        /// <param name="archive"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APIAssignmentCursor> FindAssignmentsAsync(
            string? name = default,
            global::System.Collections.Generic.IList<string>? projects = default,
            string? annotator = default,
            string? status = default,
            double? pageOffset = default,
            double? pageSize = default,
            string? taskId = default,
            bool? active = default,
            bool? archive = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFindAssignmentsArguments(
                httpClient: HttpClient,
                name: ref name,
                projects: projects,
                annotator: ref annotator,
                status: ref status,
                pageOffset: ref pageOffset,
                pageSize: ref pageSize,
                taskId: ref taskId,
                active: ref active,
                archive: ref archive);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: "/assignments",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("projects", projects, delimiter: ",", explode: true)
                .AddOptionalParameter("annotator", annotator)
                .AddOptionalParameter("status", status)
                .AddOptionalParameter("pageOffset", pageOffset?.ToString())
                .AddOptionalParameter("pageSize", pageSize?.ToString())
                .AddOptionalParameter("taskId", taskId)
                .AddOptionalParameter("active", active?.ToString().ToLowerInvariant())
                .AddOptionalParameter("archive", archive?.ToString().ToLowerInvariant()) 
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
            PrepareFindAssignmentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                name: name,
                projects: projects,
                annotator: annotator,
                status: status,
                pageOffset: pageOffset,
                pageSize: pageSize,
                taskId: taskId,
                active: active,
                archive: archive);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFindAssignmentsResponse(
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
                ProcessFindAssignmentsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.APIAssignmentCursor.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dataloop.APIAssignmentCursor.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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