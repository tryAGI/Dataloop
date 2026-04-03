
#nullable enable

namespace Dataloop
{
    public partial class TasksClient
    {
        partial void PrepareFindTasksArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? projects,
            ref string? dataset,
            ref string? recipe,
            ref string? status,
            ref string? creator,
            ref string? taskOwner,
            ref string? name,
            ref double? minDate,
            ref double? maxDate,
            global::System.Collections.Generic.IList<string>? assignments,
            ref double? pageOffset,
            ref double? pageSize,
            ref string? parentTaskId,
            ref string? type,
            ref bool? archive);
        partial void PrepareFindTasksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? projects,
            string? dataset,
            string? recipe,
            string? status,
            string? creator,
            string? taskOwner,
            string? name,
            double? minDate,
            double? maxDate,
            global::System.Collections.Generic.IList<string>? assignments,
            double? pageOffset,
            double? pageSize,
            string? parentTaskId,
            string? type,
            bool? archive);
        partial void ProcessFindTasksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFindTasksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Find tasks by query
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="dataset"></param>
        /// <param name="recipe"></param>
        /// <param name="status"></param>
        /// <param name="creator"></param>
        /// <param name="taskOwner"></param>
        /// <param name="name"></param>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <param name="assignments"></param>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentTaskId"></param>
        /// <param name="type"></param>
        /// <param name="archive"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APITaskCursor> FindTasksAsync(
            global::System.Collections.Generic.IList<string>? projects = default,
            string? dataset = default,
            string? recipe = default,
            string? status = default,
            string? creator = default,
            string? taskOwner = default,
            string? name = default,
            double? minDate = default,
            double? maxDate = default,
            global::System.Collections.Generic.IList<string>? assignments = default,
            double? pageOffset = default,
            double? pageSize = default,
            string? parentTaskId = default,
            string? type = default,
            bool? archive = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFindTasksArguments(
                httpClient: HttpClient,
                projects: projects,
                dataset: ref dataset,
                recipe: ref recipe,
                status: ref status,
                creator: ref creator,
                taskOwner: ref taskOwner,
                name: ref name,
                minDate: ref minDate,
                maxDate: ref maxDate,
                assignments: assignments,
                pageOffset: ref pageOffset,
                pageSize: ref pageSize,
                parentTaskId: ref parentTaskId,
                type: ref type,
                archive: ref archive);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: "/tasks",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("projects", projects, delimiter: ",", explode: true)
                .AddOptionalParameter("dataset", dataset)
                .AddOptionalParameter("recipe", recipe)
                .AddOptionalParameter("status", status)
                .AddOptionalParameter("creator", creator)
                .AddOptionalParameter("taskOwner", taskOwner)
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("minDate", minDate?.ToString())
                .AddOptionalParameter("maxDate", maxDate?.ToString())
                .AddOptionalParameter("assignments", assignments, delimiter: ",", explode: true)
                .AddOptionalParameter("pageOffset", pageOffset?.ToString())
                .AddOptionalParameter("pageSize", pageSize?.ToString())
                .AddOptionalParameter("parentTaskId", parentTaskId)
                .AddOptionalParameter("type", type)
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
            PrepareFindTasksRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projects: projects,
                dataset: dataset,
                recipe: recipe,
                status: status,
                creator: creator,
                taskOwner: taskOwner,
                name: name,
                minDate: minDate,
                maxDate: maxDate,
                assignments: assignments,
                pageOffset: pageOffset,
                pageSize: pageSize,
                parentTaskId: parentTaskId,
                type: type,
                archive: archive);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFindTasksResponse(
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
                ProcessFindTasksResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.APITaskCursor.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Dataloop.APITaskCursor.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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