
#nullable enable

namespace Dataloop
{
    public partial class AnnotationTasksClient
    {
        partial void PrepareQueryAnnotationTasksArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Dataloop.QueryFilter request);
        partial void PrepareQueryAnnotationTasksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Dataloop.QueryFilter request);
        partial void ProcessQueryAnnotationTasksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQueryAnnotationTasksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # List all tasks.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer* or *annotation manager* who has been assigned the task.<br/>
        /// # <br/>
        /// # :param project_ids: search tasks by given list of project ids<br/>
        /// # :param str status: search tasks by a given task status<br/>
        /// # :param str task_name: search tasks by a given task name<br/>
        /// # :param int pages_size: pages size of the output generator<br/>
        /// # :param int page_offset: page offset of the output generator<br/>
        /// # :param dtlpy.entities.recipe.Recipe recipe: Search tasks that use a given recipe. Provide the required recipe object<br/>
        /// # :param str creator: search tasks created by a given creator (user email)<br/>
        /// # :param dtlpy.entities.assignment.Assignment recipe assignments: assignments object<br/>
        /// # :param double min_date: search all tasks created AFTER a given date, use a milliseconds format. For example: 1661780622008<br/>
        /// # :param double max_date: search all tasks created BEFORE a given date, use a milliseconds format. For example: 1661780622008<br/>
        /// # :param dtlpy.entities.filters.Filters filters: dl.Filters entity to filters tasks using DQL<br/>
        /// # :return: List of Task objects<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.tasks.list(project_ids='project_ids',pages_size=100, page_offset=0)<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAny> QueryAnnotationTasksAsync(

            global::Dataloop.QueryFilter request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareQueryAnnotationTasksArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: "/annotationtasks/query",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareQueryAnnotationTasksRequest(
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
            ProcessQueryAnnotationTasksResponse(
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
                ProcessQueryAnnotationTasksResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.CursorPageAny.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dataloop.CursorPageAny.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="resource"></param>
        /// <param name="filter"></param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAny> QueryAnnotationTasksAsync(
            global::Dataloop.QueryFilterContext context,
            double page,
            double pageSize,
            global::Dataloop.QueryResource resource,
            global::Dataloop.Dictionary filter,
            global::Dataloop.Dictionary? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.QueryFilter
            {
                Context = context,
                Page = page,
                PageSize = pageSize,
                Resource = resource,
                Filter = filter,
                Sort = sort,
            };

            return await QueryAnnotationTasksAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}