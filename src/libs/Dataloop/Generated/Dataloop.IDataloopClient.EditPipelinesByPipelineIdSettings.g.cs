#nullable enable

namespace Dataloop
{
    public partial interface IDataloopClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update pipeline settings.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.pipeline.Pipeline pipeline: pipeline entity<br/>
        /// # :param dtlpy.entities.pipeline.PipelineSettings settings: settings entity<br/>
        /// # :return: Pipeline object<br/>
        /// # :rtype: dtlpy.entities.pipeline.Pipeline<br/>
        /// # <br/>
        /// # <br/>
        /// # pipeline = project.pipelines.update_settings(pipeline='pipeline_entity', settings=dl.PipelineSettings(keep_triggers_active=True))<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task EditPipelinesByPipelineIdSettingsAsync(
            string pipelineId,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}