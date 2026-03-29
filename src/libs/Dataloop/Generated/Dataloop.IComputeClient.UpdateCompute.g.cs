#nullable enable

namespace Dataloop
{
    public partial interface IComputeClient
    {
        /// <summary>
        /// Update Driver Compute.
        /// </summary>
        /// <param name="computeId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICompute> UpdateComputeAsync(
            string computeId,

            global::Dataloop.AllOf<global::Dataloop.PartialICompute, global::Dataloop.UpdateComputeRequest2> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Driver Compute.
        /// </summary>
        /// <param name="computeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICompute> UpdateComputeAsync(
            string computeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}