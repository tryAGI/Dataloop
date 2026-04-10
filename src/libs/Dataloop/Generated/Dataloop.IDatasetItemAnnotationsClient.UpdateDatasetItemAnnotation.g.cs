#nullable enable

namespace Dataloop
{
    public partial interface IDatasetItemAnnotationsClient
    {
        /// <summary>
        /// Update an item's annotation
        /// </summary>
        /// <param name="annotationId"></param>
        /// <param name="system"></param>
        /// <param name="replace"></param>
        /// <param name="datasetId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAnnotation> UpdateDatasetItemAnnotationAsync(
            string annotationId,
            string datasetId,
            string itemId,

            global::Dataloop.UpdateAnnotationRequest request,
            bool? system = default,
            bool? replace = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an item's annotation
        /// </summary>
        /// <param name="annotationId"></param>
        /// <param name="system"></param>
        /// <param name="replace"></param>
        /// <param name="datasetId"></param>
        /// <param name="itemId"></param>
        /// <param name="creator"></param>
        /// <param name="type"></param>
        /// <param name="label"></param>
        /// <param name="coordinates"></param>
        /// <param name="attributes"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAnnotation> UpdateDatasetItemAnnotationAsync(
            string annotationId,
            string datasetId,
            string itemId,
            string creator,
            global::Dataloop.AnnotationType type,
            string label,
            bool? system = default,
            bool? replace = default,
            object? coordinates = default,
            global::System.Collections.Generic.IList<string>? attributes = default,
            global::Dataloop.APIMetadata? metadata = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}