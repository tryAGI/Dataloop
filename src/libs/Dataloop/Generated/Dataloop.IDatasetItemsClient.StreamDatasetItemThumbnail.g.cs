#nullable enable

namespace Dataloop
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="annotations"></param>
        /// <param name="annotationsV2"></param>
        /// <param name="queryHash"></param>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task StreamDatasetItemThumbnailAsync(
            string id,
            string datasetId,
            double? width = default,
            double? height = default,
            bool? annotations = default,
            bool? annotationsV2 = default,
            string? queryHash = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}