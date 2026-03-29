#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Get logs for pipelines.
        /// </summary>
        /// <param name="verbose"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// service_logs = package.services.log(service='service_entity')<br/>
        /// # <br/>
        /// # Get service logs.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.service.Service service: service object<br/>
        /// # :param int size: size<br/>
        /// # :param dict checkpoint: the information from the lst point checked in the service<br/>
        /// # :param str start: iso format time<br/>
        /// # :param str end: iso format time<br/>
        /// # :param bool follow: if true, keep stream future logs<br/>
        /// # :param str text: text<br/>
        /// # :param str execution_id: execution id<br/>
        /// # :param str function_name: function name<br/>
        /// # :param str replica_id: replica id<br/>
        /// # :param bool system: system<br/>
        /// # :param bool view: if true, print out all the logs<br/>
        /// # :param bool until_completed: wait until completed<br/>
        /// # :param str log_level: the log level to display dl.LoggingLevel<br/>
        /// # :param str model_id: model id<br/>
        /// # :param str model_operation: model operation action<br/>
        /// # :param str project_id: project id<br/>
        /// # :return: ServiceLog entity<br/>
        /// # :rtype: ServiceLog<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.ServiceLogsPage> GetLogsAsync(
            string verbose,

            global::Dataloop.LogQuery request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get logs for pipelines.
        /// </summary>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.ServiceLogsPage> GetLogsAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}