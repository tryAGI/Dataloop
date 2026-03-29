#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// pipeline = project.pipelines.update_settings(pipeline='pipeline_entity', settings=dl.PipelineSettings(keep_triggers_active=True))<br/>
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
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> UpdateSettingsAsync(
            string pipelineId,

            global::Dataloop.IPipelineSettings request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="defaultResumeOption"></param>
        /// <param name="keepTriggersActive"></param>
        /// <param name="activeTriggerAskAgain"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> UpdateSettingsAsync(
            string pipelineId,
            global::Dataloop.IPipelineSettingsLastUpdate lastUpdate,
            global::Dataloop.ResumePipelineOption? defaultResumeOption = default,
            bool? keepTriggersActive = default,
            bool? activeTriggerAskAgain = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}