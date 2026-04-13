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
        /// # Get Service execution object<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # :param str execution_id: execution id<br/>
        /// # :param bool sync: if true, wait for the execution to finish<br/>
        /// # :return: Service execution object<br/>
        /// # :rtype: dtlpy.entities.execution.Execution<br/>
        /// # <br/>
        /// # <br/>
        /// # service.executions.get(execution_id='execution_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task GetExecutionsByIdAsync(
            string id,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}