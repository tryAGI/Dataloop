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
        /// project.pipelines.pause(pipeline='pipeline_entity')<br/>
        /// # <br/>
        /// # Pause a pipeline.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.pipeline.Pipeline pipeline: pipeline entity<br/>
        /// # :param bool keep_triggers_active: Do we want the triggers to stay active and collect events<br/>
        /// # :return: Composition object<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> UninstallAsync(
            string pipelineId,

            global::Dataloop.UninstallRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="value">
        /// Boolean value
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> UninstallAsync(
            string pipelineId,
            bool? value = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}