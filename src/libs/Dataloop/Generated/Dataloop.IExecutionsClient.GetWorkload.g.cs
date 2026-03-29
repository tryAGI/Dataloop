#nullable enable

namespace Dataloop
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Get Workload.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIExecution>> GetWorkloadAsync(

            global::Dataloop.WorkloadParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Workload.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="serviceId"></param>
        /// <param name="load"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIExecution>> GetWorkloadAsync(
            string agentId,
            string serviceId,
            double load,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}