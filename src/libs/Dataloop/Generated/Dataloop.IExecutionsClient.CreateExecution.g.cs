#nullable enable

namespace Dataloop
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Execute a function on an existing service.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="waitUntilExecutionIsFinished"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Execute a function on an existing service<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # :param str service_id: service id to execute on<br/>
        /// # :param filters: Filters entity for a filtering before execute<br/>
        /// # :param str function_name: function name to run<br/>
        /// # :param List[FunctionIO] or dict execution_inputs: input dictionary or list of FunctionIO entities, that represent the extra inputs of the function<br/>
        /// # :param bool wait: wait until create task finish<br/>
        /// # :return: execution object<br/>
        /// # :rtype: dtlpy.entities.execution.Execution<br/>
        /// # <br/>
        /// # <br/>
        /// # command = service.executions.create_batch(<br/>
        /// # execution_inputs=dl.FunctionIO(type=dl.PackageInputType.STRING, value='test', name='string'),<br/>
        /// # filters=dl.Filters(field='dir', values='/test'),<br/>
        /// # function_name='run')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.APICommand>> CreateExecutionAsync(
            string serviceId,
            bool waitUntilExecutionIsFinished,

            global::Dataloop.CreateExecutionRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a function on an existing service.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="waitUntilExecutionIsFinished"></param>
        /// <param name="mode"></param>
        /// <param name="pipeline"></param>
        /// <param name="projectId"></param>
        /// <param name="input"></param>
        /// <param name="functionName"></param>
        /// <param name="batch"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.APICommand>> CreateExecutionAsync(
            string serviceId,
            bool waitUntilExecutionIsFinished,
            string projectId,
            global::Dataloop.Dictionary input,
            string functionName,
            global::Dataloop.ExecutionMode? mode = default,
            global::Dataloop.IPipelineExecution? pipeline = default,
            global::Dataloop.ExecuteOptionsBatch? batch = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}