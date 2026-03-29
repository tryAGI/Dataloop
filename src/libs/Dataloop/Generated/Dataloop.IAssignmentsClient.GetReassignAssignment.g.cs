#nullable enable

namespace Dataloop
{
    public partial interface IAssignmentsClient
    {
        /// <summary>
        /// Get the latest reassign command
        /// </summary>
        /// <param name="id"></param>
        /// <param name="creator"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> GetReassignAssignmentAsync(
            string id,
            string? creator = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}