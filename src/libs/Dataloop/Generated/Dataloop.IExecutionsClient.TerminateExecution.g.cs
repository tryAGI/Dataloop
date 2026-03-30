#nullable enable

namespace Dataloop
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Terminate Execution.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Terminate Execution<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.execution.Execution execution:<br/>
        /// # :return: execution object<br/>
        /// # :rtype: dtlpy.entities.execution.Execution<br/>
        /// # <br/>
        /// # <br/>
        /// # service.executions.terminate(execution='execution_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIExecution> TerminateExecutionAsync(
            string id,

            global::Dataloop.ExecutionStatusReport request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate Execution.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timestamp"></param>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="percentComplete"></param>
        /// <param name="error"></param>
        /// <param name="output"></param>
        /// <param name="action"></param>
        /// <param name="replicaId"></param>
        /// <param name="replicaType"></param>
        /// <param name="skipUpdate"></param>
        /// <param name="hookResolved"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIExecution> TerminateExecutionAsync(
            string id,
            global::System.DateTime timestamp,
            global::Dataloop.ExecutionStatusName status,
            string message,
            double percentComplete,
            global::Dataloop.Dictionary? error = default,
            global::Dataloop.Dictionary? output = default,
            string? action = default,
            string? replicaId = default,
            string? replicaType = default,
            bool? skipUpdate = default,
            bool? hookResolved = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}