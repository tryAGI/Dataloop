#nullable enable

namespace Dataloop
{
    public partial interface IStorageDriversClient
    {
        /// <summary>
        /// Check storage driver integration by integration Id
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> CheckStorageDriversIntegrationByIntegrationIdAsync(

            global::Dataloop.CheckStorageDriversIntegrationByIntegrationIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check storage driver integration by integration Id
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> CheckStorageDriversIntegrationByIntegrationIdAsync(
            string integrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}