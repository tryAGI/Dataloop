#nullable enable

namespace Dataloop
{
    public partial interface IDatasetItemAnnotationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> RestoreArchivedDatasetItemAnnotationToDbAsync(
            string datasetId,
            string itemId,

            global::Dataloop.RestoreArchivedDatasetItemAnnotationToDBRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="itemId"></param>
        /// <param name="annotationLogId"></param>
        /// <param name="annotationId"></param>
        /// <param name="requestItemId"></param>
        /// <param name="requestDatasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> RestoreArchivedDatasetItemAnnotationToDbAsync(
            string datasetId,
            string itemId,
            string requestItemId,
            string requestDatasetId,
            string? annotationLogId = default,
            string? annotationId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}