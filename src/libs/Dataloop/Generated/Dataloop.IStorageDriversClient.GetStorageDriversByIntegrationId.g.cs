#nullable enable

namespace Dataloop
{
    public partial interface IStorageDriversClient
    {
        /// <summary>
        /// Get Amount of drivers by integrationId
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<double> GetStorageDriversByIntegrationIdAsync(
            string integrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}