#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Reset pipeline counters.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Reset pipeline counters.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.pipeline.Pipeline pipeline: pipeline entity - optional<br/>
        /// # :param str pipeline_id: pipeline_id -  optional<br/>
        /// # :param str pipeline_name: pipeline_name -  optional<br/>
        /// # :param bool stop_if_running: If the pipeline is installed it will stop the pipeline and reset the counters.<br/>
        /// # :return: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # success = project.pipelines.reset(pipeline='pipeline_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> ResetAsync(
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}