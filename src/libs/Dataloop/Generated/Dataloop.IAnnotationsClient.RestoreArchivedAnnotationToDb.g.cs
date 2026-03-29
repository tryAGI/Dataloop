#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> RestoreArchivedAnnotationToDbAsync(

            global::Dataloop.RestoreArchivedAnnotationToDBRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="annotationLogId"></param>
        /// <param name="annotationId"></param>
        /// <param name="itemId"></param>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> RestoreArchivedAnnotationToDbAsync(
            string itemId,
            string datasetId,
            string? annotationLogId = default,
            string? annotationId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}