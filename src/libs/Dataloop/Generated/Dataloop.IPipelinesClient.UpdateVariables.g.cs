#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> UpdateVariablesAsync(
            string pipelineId,

            global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}