#nullable enable

namespace Dataloop
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Get an execution by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sync"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// service.executions.get(execution_id='execution_id')<br/>
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
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIExecution> GetExecutionAsync(
            string id,
            bool sync,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}