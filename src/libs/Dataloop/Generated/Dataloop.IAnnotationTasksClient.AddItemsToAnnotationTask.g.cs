#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationTasksClient
    {
        /// <summary>
        /// Add work to an existing Task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> AddItemsToAnnotationTaskAsync(
            string id,

            global::Dataloop.AddToTaskPayload request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> AddItemsToAnnotationTaskAsync(
            string id,
            string query,
            global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? workload = default,
            double? limit = default,
            bool? percentage = default,
            bool? asynced = default,
            bool? disableWebm = default,
            global::System.Collections.Generic.IList<string>? groups = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}