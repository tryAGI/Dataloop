#nullable enable

namespace Dataloop
{
    public partial interface IDataloopClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get pipeline counters.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.pipeline.Pipeline pipeline: pipeline entity - optional<br/>
        /// # :param str pipeline_id: pipeline_id -  optional<br/>
        /// # :param str pipeline_name: pipeline_name -  optional<br/>
        /// # :return: PipelineStats<br/>
        /// # :rtype: dtlpy.entities.pipeline.PipelineStats<br/>
        /// # <br/>
        /// # <br/>
        /// # pipeline_stats = project.pipelines.stats(pipeline='pipeline_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task GetPipelinesByIdStatisticsAsync(
            string id,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}