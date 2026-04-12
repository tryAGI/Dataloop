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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Install (start) a pipeline.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.pipeline.Pipeline pipeline: pipeline entity<br/>
        /// # :param dtlpy.entities.pipeline.PipelineResumeOption resume_option: optional - resume pipeline method (what to do with existing cycles)<br/>
        /// # :return: Composition object<br/>
        /// # <br/>
        /// # <br/>
        /// # project.pipelines.install(pipeline='pipeline_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> InstallAsync(
            string pipelineId,

            global::Dataloop.InstallRequest2 request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="resumeOption"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> InstallAsync(
            string pipelineId,
            global::Dataloop.ResumePipelineOption? resumeOption = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}