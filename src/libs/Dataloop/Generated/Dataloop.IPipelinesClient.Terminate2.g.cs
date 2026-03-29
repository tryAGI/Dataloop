#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Delete the pipeline, should terminate the composition.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Terminate2Async(
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}