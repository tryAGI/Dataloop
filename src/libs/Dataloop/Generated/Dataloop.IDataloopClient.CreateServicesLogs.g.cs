#nullable enable

namespace Dataloop
{
    public partial interface IDataloopClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
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
        /// # <br/>
        /// # service_logs = package.services.log(service='service_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task CreateServicesLogsAsync(
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}