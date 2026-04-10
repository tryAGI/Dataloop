#nullable enable

namespace Dataloop
{
    public partial interface IModelMetricsClient
    {
        /// <summary>
        /// Get Model Precision Recall<br/>
        /// Calaculate the precision and recall for a model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CalaculateThePrecisionAndRecallForAModelAsync(

            global::Dataloop.PrecisionRecallInputRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Model Precision Recall<br/>
        /// Calaculate the precision and recall for a model
        /// </summary>
        /// <param name="modelId">
        /// The model that calculated on it
        /// </param>
        /// <param name="datasetId">
        /// The dataset that calculated on it
        /// </param>
        /// <param name="iouThreshold">
        /// The iouThreshold of the calculation
        /// </param>
        /// <param name="metric">
        /// The metric to calculation the confusion Matrix
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CalaculateThePrecisionAndRecallForAModelAsync(
            string modelId,
            string datasetId,
            double iouThreshold,
            string? metric = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}