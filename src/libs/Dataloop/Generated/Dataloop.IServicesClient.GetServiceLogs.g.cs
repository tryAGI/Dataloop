#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Get service logs.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="verbose"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.ServiceLogsPage> GetServiceLogsAsync(
            string id,
            string verbose,

            global::Dataloop.LogQuery request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get service logs.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="verbose"></param>
        /// <param name="serviceId"></param>
        /// <param name="follow"></param>
        /// <param name="size"></param>
        /// <param name="checkpoint"></param>
        /// <param name="direction"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="executionId"></param>
        /// <param name="functionName"></param>
        /// <param name="replicaId"></param>
        /// <param name="text"></param>
        /// <param name="logLevel"></param>
        /// <param name="pipelineId"></param>
        /// <param name="nodeId"></param>
        /// <param name="pipelineExecutionId"></param>
        /// <param name="system"></param>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="modelOperation"></param>
        /// <param name="includeServiceLevel"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.ServiceLogsPage> GetServiceLogsAsync(
            string id,
            string verbose,
            string? serviceId = default,
            bool? follow = default,
            double? size = default,
            string? checkpoint = default,
            global::Dataloop.LogsListDirection? direction = default,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? executionId = default,
            string? functionName = default,
            string? replicaId = default,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? text = default,
            global::Dataloop.ServiceLogLevel? logLevel = default,
            string? pipelineId = default,
            string? nodeId = default,
            string? pipelineExecutionId = default,
            bool? system = default,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? projectId = default,
            string? modelId = default,
            string? modelOperation = default,
            bool? includeServiceLevel = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}