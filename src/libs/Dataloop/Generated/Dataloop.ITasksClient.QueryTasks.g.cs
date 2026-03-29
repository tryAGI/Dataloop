#nullable enable

namespace Dataloop
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAny> QueryTasksAsync(

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
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAny> QueryTasksAsync(
            global::Dataloop.QueryFilterContext context,
            double page,
            double pageSize,
            global::Dataloop.QueryResource resource,
            global::Dataloop.Dictionary filter,
            global::Dataloop.Dictionary? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}