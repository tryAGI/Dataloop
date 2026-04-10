#nullable enable

namespace Dataloop
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> CloneDatasetItemAsync(
            string id,
            string datasetId,

            global::Dataloop.ItemCloneRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="datasetId"></param>
        /// <param name="targetDatasetId">
        /// Target dataset id
        /// </param>
        /// <param name="remoteFileName">
        /// path at target dataset
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="cloneDatasetParams"></param>
        /// <param name="allowMany">
        /// allow multiple copies of the same source item<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> CloneDatasetItemAsync(
            string id,
            string datasetId,
            string targetDatasetId,
            global::Dataloop.CloneDatasetParams cloneDatasetParams,
            string? remoteFileName = default,
            global::Dataloop.Dictionary? metadata = default,
            bool? allowMany = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}