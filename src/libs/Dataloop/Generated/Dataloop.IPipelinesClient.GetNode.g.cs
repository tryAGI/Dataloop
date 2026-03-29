#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// get one of pipeline nodes by pipeline id and node id.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="nodeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.NodeDescriptor> GetNodeAsync(
            string pipelineId,
            string nodeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}