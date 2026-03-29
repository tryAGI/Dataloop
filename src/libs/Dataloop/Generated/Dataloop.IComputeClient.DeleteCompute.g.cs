#nullable enable

namespace Dataloop
{
    public partial interface IComputeClient
    {
        /// <summary>
        /// Delete Driver Compute.
        /// </summary>
        /// <param name="computeId"></param>
        /// <param name="skipDestroy">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, object>> DeleteComputeAsync(
            string computeId,
            bool? skipDestroy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}