#nullable enable

namespace Dataloop
{
    public partial interface IStorageDriversClient
    {
        /// <summary>
        /// Update integrationId and integrationType for multiple drivers (Migration endpoint - requires sudo)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.UpdateDriversIntegrationResult> MigrateDriversIntegrationAsync(

            global::Dataloop.MigrateDriversIntegrationRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update integrationId and integrationType for multiple drivers (Migration endpoint - requires sudo)
        /// </summary>
        /// <param name="newIntegrationType"></param>
        /// <param name="newIntegrationId"></param>
        /// <param name="driverIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.UpdateDriversIntegrationResult> MigrateDriversIntegrationAsync(
            string newIntegrationType,
            string newIntegrationId,
            global::System.Collections.Generic.IList<string> driverIds,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}