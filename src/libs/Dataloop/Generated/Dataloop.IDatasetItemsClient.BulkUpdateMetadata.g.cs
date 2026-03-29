#nullable enable

namespace Dataloop
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> BulkUpdateMetadataAsync(
            string datasetId,

            global::Dataloop.BulkUpdateMetadataRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="updateQuery"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> BulkUpdateMetadataAsync(
            string datasetId,
            global::Dataloop.UpdateItemMetadataOptions updateQuery,
            global::Dataloop.DQLResourceQuery query,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}