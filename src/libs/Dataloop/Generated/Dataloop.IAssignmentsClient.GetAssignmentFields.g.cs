#nullable enable

namespace Dataloop
{
    public partial interface IAssignmentsClient
    {
        /// <summary>
        /// Get a specific assignment fields
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.PartialAssignment> GetAssignmentFieldsAsync(
            string id,

            global::Dataloop.GetAssignmentFieldsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a specific assignment fields
        /// </summary>
        /// <param name="id"></param>
        /// <param name="relatedItemId"></param>
        /// <param name="fields"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.PartialAssignment> GetAssignmentFieldsAsync(
            string id,
            global::System.Collections.Generic.IList<string> fields,
            string? relatedItemId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}