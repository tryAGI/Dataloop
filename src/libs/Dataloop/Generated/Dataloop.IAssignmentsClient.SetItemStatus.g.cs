#nullable enable

namespace Dataloop
{
    public partial interface IAssignmentsClient
    {
        /// <summary>
        /// Set status to one item in an assignment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Dictionary> SetItemStatusAsync(
            string id,
            string itemId,

            global::Dataloop.AssignmentStatusPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set status to one item in an assignment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="itemId"></param>
        /// <param name="operation"></param>
        /// <param name="status"></param>
        /// <param name="returnLastStatus"></param>
        /// <param name="asynced"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Dictionary> SetItemStatusAsync(
            string id,
            string itemId,
            global::Dataloop.ItemRefOperation operation,
            string? status = default,
            bool? returnLastStatus = default,
            bool? asynced = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}