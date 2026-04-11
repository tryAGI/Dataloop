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
        /// # Pause a pipeline.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.pipeline.Pipeline pipeline: pipeline entity<br/>
        /// # :param bool keep_triggers_active: Do we want the triggers to stay active and collect events<br/>
        /// # :return: Composition object<br/>
        /// # <br/>
        /// # <br/>
        /// # project.pipelines.pause(pipeline='pipeline_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task CreatePipelinesByPipelineIdUninstallAsync(
            string pipelineId,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}