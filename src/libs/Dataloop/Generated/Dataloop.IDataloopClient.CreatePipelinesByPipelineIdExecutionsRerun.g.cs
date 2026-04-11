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
        /// # Get Pipeline Execution object<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param str pipeline_id: pipeline id<br/>
        /// # :param str method: method to run<br/>
        /// # :param list start_nodes_ids: list of start nodes ids<br/>
        /// # :param filters: Filters entity for a filtering before execute<br/>
        /// # :param bool wait: wait until rerun finish<br/>
        /// # :return: True if success<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # pipeline.pipeline_executions.rerun(pipeline_id='pipeline_id', method=dl.CycleRerunMethod.START_FROM_BEGINNING)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task CreatePipelinesByPipelineIdExecutionsRerunAsync(
            string pipelineId,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}