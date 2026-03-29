#nullable enable

namespace Dataloop
{
    public partial interface IComputeClient
    {
        /// <summary>
        /// Validate Compute.
        /// </summary>
        /// <param name="computeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICompute> ValidateComputeAsync(
            string computeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}