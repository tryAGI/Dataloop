#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Deletes all expired items<br/>
        /// Each dataset has the option to set it's SLA according to the attached example<br/>
        /// When setting expirationOptions.itemMaxAge to a number (100 for example),<br/>
        /// Each item in the dataset will be deleted once the corresponding number of days have passed since it's creation
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> DeleteExpiredItemsAsync(
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}