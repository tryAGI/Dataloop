#nullable enable

namespace Dataloop
{
    public partial interface IStorageDriversClient
    {
        /// <summary>
        /// Update storage driver configuration
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDriverConfiguration> UpdateStorageDriverAsync(
            string id,

            global::Dataloop.PartialDriverPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update storage driver configuration
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="payload"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDriverConfiguration> UpdateStorageDriverAsync(
            string id,
            global::Dataloop.AnyOf<global::Dataloop.PartialS3DriverPayload, global::Dataloop.PartialGcsDriverPayload, global::Dataloop.PartialAzureBlobDriverPayload> payload,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}