#nullable enable

namespace Dataloop
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Nack execution.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> NackAsync(
            string id,

            global::Dataloop.NackRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Nack execution.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> NackAsync(
            string id,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}