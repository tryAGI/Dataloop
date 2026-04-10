#nullable enable

namespace Dataloop
{
    public partial interface IModelMetricsClient
    {
        /// <summary>
        /// Generate Model Metrics Report<br/>
        /// Supply single or multiple Model ids to generate report for
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.Dictionary>> GenerateModelMetricsReportAsync(

            global::Dataloop.GenerateModelMetricsReportRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Model Metrics Report<br/>
        /// Supply single or multiple Model ids to generate report for
        /// </summary>
        /// <param name="datasetIds">
        /// The dataset or datasets to generate report for
        /// </param>
        /// <param name="modelIds">
        /// The models to generate report for
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.Dictionary>> GenerateModelMetricsReportAsync(
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>> modelIds,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? datasetIds = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}