#nullable enable

namespace Dataloop
{
    public partial interface IComputeClient
    {
        /// <summary>
        /// Cleanup org driver
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task CleanupOrgAsync(
            string orgId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}