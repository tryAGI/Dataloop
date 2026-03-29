#nullable enable

namespace Dataloop
{
    public partial interface IAssignmentsClient
    {
        /// <summary>
        /// Set bulk items status by assignment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetItemStatusBulkAssignmentAsync(
            string id,

            global::Dataloop.SetItemStatusBulkAssignmentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set bulk items status by assignment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="statusPayload"></param>
        /// <param name="itemIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetItemStatusBulkAssignmentAsync(
            string id,
            global::Dataloop.AssignmentStatusPayload statusPayload,
            global::System.Collections.Generic.IList<string> itemIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}