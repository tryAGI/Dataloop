#nullable enable

namespace Dataloop
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Update execution changes to platform.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update execution changes to platform<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.execution.Execution execution: execution entity<br/>
        /// # :return: Service execution object<br/>
        /// # :rtype: dtlpy.entities.execution.Execution<br/>
        /// # <br/>
        /// # <br/>
        /// # service.executions.update(execution='execution_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIExecution> UpdateExecutionAsync(
            string id,

            global::Dataloop.APIExecutionPatch request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update execution changes to platform.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="duration"></param>
        /// <param name="serviceVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIExecution> UpdateExecutionAsync(
            string id,
            double? duration = default,
            string? serviceVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}