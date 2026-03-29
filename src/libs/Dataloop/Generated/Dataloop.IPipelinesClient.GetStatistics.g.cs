#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Get pipeline counters.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.IPipelineStatistics> GetStatisticsAsync(
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}