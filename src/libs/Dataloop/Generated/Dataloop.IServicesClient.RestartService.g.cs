#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Restart service.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="replicaName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task RestartServiceAsync(
            string id,
            string? replicaName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}