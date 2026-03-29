#nullable enable

namespace Dataloop
{
    public partial interface IModelMetricsClient
    {
        /// <summary>
        /// Delete a Metric<br/>
        /// Supply the unique id of the Metric to delete
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteMetricAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}