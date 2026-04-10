#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// For org admin / owner:<br/>
        /// Get datasets count for projects<br/>
        /// Get datasets if a single project required
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.GetDatasetsByProjectIdsResponse> GetDatasetsByProjectIdsAsync(

            global::Dataloop.GetDatasetsByProjectIdsRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// For org admin / owner:<br/>
        /// Get datasets count for projects<br/>
        /// Get datasets if a single project required
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="system">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.GetDatasetsByProjectIdsResponse> GetDatasetsByProjectIdsAsync(
            global::System.Collections.Generic.IList<string> projectIds,
            bool? system = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}