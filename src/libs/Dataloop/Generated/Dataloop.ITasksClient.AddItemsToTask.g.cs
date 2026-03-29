#nullable enable

namespace Dataloop
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Add work to an existing Task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> AddItemsToTaskAsync(
            string id,

            global::Dataloop.AddToTaskPayload request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> AddItemsToTaskAsync(
            string id,
            string query,
            global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? workload = default,
            double? limit = default,
            bool? percentage = default,
            bool? asynced = default,
            bool? disableWebm = default,
            global::System.Collections.Generic.IList<string>? groups = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}