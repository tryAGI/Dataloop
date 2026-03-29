#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="piplineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.PipelineExecutionLogs>> LogsAsync(
            string piplineId,

            global::Dataloop.LogsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="piplineId"></param>
        /// <param name="query"></param>
        /// <param name="logsOptions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.PipelineExecutionLogs>> LogsAsync(
            string piplineId,
            global::Dataloop.QueryString query,
            global::Dataloop.LogQuery logsOptions,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}