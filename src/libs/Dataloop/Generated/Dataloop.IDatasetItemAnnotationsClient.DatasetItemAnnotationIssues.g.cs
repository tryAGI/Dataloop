#nullable enable

namespace Dataloop
{
    public partial interface IDatasetItemAnnotationsClient
    {
        /// <summary>
        /// Update an item's annotation status to issue
        /// </summary>
        /// <param name="annotationId"></param>
        /// <param name="datasetId"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAnnotation> DatasetItemAnnotationIssuesAsync(
            string annotationId,
            string datasetId,
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}