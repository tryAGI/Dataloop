#nullable enable

namespace Dataloop
{
    public partial interface IModelMetricsClient
    {
        /// <summary>
        /// Publish Model Metrics<br/>
        /// Supply single or multiple metrics to publish
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.PublishModelMetricsResponse> PublishModelMetricsAsync(

            global::Dataloop.AnyOf<global::Dataloop.MetricRequest, global::System.Collections.Generic.IList<global::Dataloop.MetricRequest>> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish Model Metrics<br/>
        /// Supply single or multiple metrics to publish
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.PublishModelMetricsResponse> PublishModelMetricsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}