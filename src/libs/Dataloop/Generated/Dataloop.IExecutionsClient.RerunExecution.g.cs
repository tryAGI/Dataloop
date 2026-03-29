#nullable enable

namespace Dataloop
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Rerun execution.
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="waitUntilExecutionIsFinished"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// service.executions.rerun(execution='execution_entity')<br/>
        /// # <br/>
        /// # Rerun execution<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.execution.Execution execution:<br/>
        /// # :param bool sync: wait for the execution to finish<br/>
        /// # :return: Execution object<br/>
        /// # :rtype: dtlpy.entities.execution.Execution<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.PiperSettingsCommands>> RerunExecutionAsync(
            string executionId,
            bool waitUntilExecutionIsFinished,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}