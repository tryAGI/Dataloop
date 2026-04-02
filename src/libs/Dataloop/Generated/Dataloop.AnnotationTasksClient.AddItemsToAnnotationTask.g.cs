
#nullable enable

namespace Dataloop
{
    public partial class AnnotationTasksClient
    {
        partial void PrepareAddItemsToAnnotationTaskArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            global::Dataloop.AddToTaskPayload request);
        partial void PrepareAddItemsToAnnotationTaskRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            global::Dataloop.AddToTaskPayload request);
        partial void ProcessAddItemsToAnnotationTaskResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddItemsToAnnotationTaskResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add work to an existing Task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Add items to a Task.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner*, *developer*, or *annotation manager* who has been assigned to be *owner* of the annotation task.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.task.Task task: task object<br/>
        /// # :param str task_id: the Id of the task<br/>
        /// # :param dtlpy.entities.filters.Filters filters: Filters entity or a dictionary containing filters parameters<br/>
        /// # :param list items: list of items (item Ids or objects) to add to the task<br/>
        /// # :param list assignee_ids: list to assignee who works in the task<br/>
        /// # :param dict query: query to filter the items for the task<br/>
        /// # :param list workload: list of WorkloadUnit objects. Customize distribution (percentage) between the task assignees. For example: [dl.WorkloadUnit(annotator@hi.com, 80), dl.WorkloadUnit(annotator2@hi.com, 20)]<br/>
        /// # :param int limit: the limit items that task can include<br/>
        /// # :param bool wait: wait until add items will to finish<br/>
        /// # :return: task entity<br/>
        /// # :rtype: dtlpy.entities.task.Task<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.tasks.add_items(task= 'task_entity',<br/>
        /// # items = [items])<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> AddItemsToAnnotationTaskAsync(
            string id,

            global::Dataloop.AddToTaskPayload request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAddItemsToAnnotationTaskArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/annotationtasks/{id}/addToTask",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAddItemsToAnnotationTaskRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAddItemsToAnnotationTaskResponse(
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
                ProcessAddItemsToAnnotationTaskResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Add work to an existing Task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="query"></param>
        /// <param name="workload"></param>
        /// <param name="limit"></param>
        /// <param name="percentage"></param>
        /// <param name="asynced"></param>
        /// <param name="disableWebm"></param>
        /// <param name="groups"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> AddItemsToAnnotationTaskAsync(
            string id,
            string query,
            global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? workload = default,
            double? limit = default,
            bool? percentage = default,
            bool? asynced = default,
            bool? disableWebm = default,
            global::System.Collections.Generic.IList<string>? groups = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.AddToTaskPayload
            {
                Query = query,
                Workload = workload,
                Limit = limit,
                Percentage = percentage,
                Asynced = asynced,
                DisableWebm = disableWebm,
                Groups = groups,
            };

            return await AddItemsToAnnotationTaskAsync(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}