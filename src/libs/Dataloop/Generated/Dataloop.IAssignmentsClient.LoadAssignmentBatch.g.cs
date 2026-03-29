#nullable enable

namespace Dataloop
{
    public partial interface IAssignmentsClient
    {
        /// <summary>
        /// Load batch to Assignment in a queueing task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>> LoadAssignmentBatchAsync(
            string id,

            global::Dataloop.BatchAssignmentPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Load batch to Assignment in a queueing task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="assignmentId"></param>
        /// <param name="asynced"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>> LoadAssignmentBatchAsync(
            string id,
            string assignmentId,
            bool? asynced = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}