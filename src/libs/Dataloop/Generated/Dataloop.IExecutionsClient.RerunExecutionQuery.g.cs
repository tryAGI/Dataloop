#nullable enable

namespace Dataloop
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Rerun batch execution.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # rerun a executions on an existing service<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a Filter.<br/>
        /// # <br/>
        /// # :param filters: Filters entity for a filtering before rerun<br/>
        /// # :param str service_id: service id to rerun on<br/>
        /// # :param bool wait: wait until create task finish<br/>
        /// # :return: rerun command<br/>
        /// # :rtype: dtlpy.entities.command.Command<br/>
        /// # <br/>
        /// # <br/>
        /// # command = service.executions.rerun_batch(<br/>
        /// # filters=dl.Filters(field='id', values=['executionId'], operator=dl.FiltersOperations.IN, resource=dl.FiltersResource.EXECUTION))<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> RerunExecutionQueryAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerun batch execution.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> RerunExecutionQueryAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}