#nullable enable

namespace Dataloop
{
    public partial interface IComputeClient
    {
        /// <summary>
        /// Apply docker private registry credentials on the user compute system.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="integrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task RegistryCredAsync(
            string orgId,
            string integrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}