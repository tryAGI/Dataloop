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
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> InvalidateAnnotationThumbnailsAsync(
            string datasetId,

            global::Dataloop.InvalidateAnnotationThumbnailsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="itemsQuery"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> InvalidateAnnotationThumbnailsAsync(
            string datasetId,
            global::Dataloop.DQLResourceQuery itemsQuery,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}