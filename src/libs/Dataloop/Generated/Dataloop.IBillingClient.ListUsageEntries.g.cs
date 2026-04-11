#nullable enable

namespace Dataloop
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="monthly"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIUsageEntry>> ListUsageEntriesAsync(
            string project,
            string startDate,
            string endDate,
            string? monthly = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}