#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Execute a pipeline and return the pipeline execution as an object - or command in case batch is defined on the body.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create batch executions of a pipeline.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param pipeline_id: pipeline id<br/>
        /// # :param filters: Filters entity for a filtering before execute<br/>
        /// # :param execution_inputs: list of the dl.FunctionIO or dict of pipeline input - example {'item': 'item_id'}, that represent the extra inputs of the function<br/>
        /// # :param bool wait: wait until create task finish<br/>
        /// # :return: entities.PipelineExecution object<br/>
        /// # :rtype: dtlpy.entities.pipeline_execution.PipelineExecution<br/>
        /// # <br/>
        /// # <br/>
        /// # command = pipeline.pipeline_executions.create_batch(<br/>
        /// # execution_inputs=dl.FunctionIO(type=dl.PackageInputType.STRING, value='test', name='string'),<br/>
        /// # filters=dl.Filters(field='dir', values='/test'))<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>> ExecuteAsync(
            string pipelineId,

            global::Dataloop.ExecuteOptions request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a pipeline and return the pipeline execution as an object - or command in case batch is defined on the body.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="batch"></param>
        /// <param name="pipeline"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>> ExecuteAsync(
            string pipelineId,
            global::Dataloop.ExecuteOptionsBatch batch,
            global::Dataloop.ExecutePipelinePayload pipeline,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}