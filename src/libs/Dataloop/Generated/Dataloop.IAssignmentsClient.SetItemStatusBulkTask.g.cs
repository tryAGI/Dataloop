#nullable enable

namespace Dataloop
{
    public partial interface IAssignmentsClient
    {
        /// <summary>
        /// Set bulk items status to their assignment by task
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetItemStatusBulkTaskAsync(
            string taskId,

            global::Dataloop.SetItemStatusBulkTaskRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set bulk items status to their assignment by task
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="statusPayload"></param>
        /// <param name="itemIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetItemStatusBulkTaskAsync(
            string taskId,
            global::Dataloop.AssignmentStatusPayload statusPayload,
            global::System.Collections.Generic.IList<string> itemIds,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}