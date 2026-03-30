#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationTasksClient
    {
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
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAny> QueryAnnotationTasksAsync(

            global::Dataloop.QueryFilter request,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAny> QueryAnnotationTasksAsync(
            global::Dataloop.QueryFilterContext context,
            double page,
            double pageSize,
            global::Dataloop.QueryResource resource,
            global::Dataloop.Dictionary filter,
            global::Dataloop.Dictionary? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}