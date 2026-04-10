#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationLogsClient
    {
        /// <summary>
        /// List all annotations of an item
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="datasetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationEvent>>> ListDatasetItemAnnotationLogsAsync(
            string itemId,
            string datasetId,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}