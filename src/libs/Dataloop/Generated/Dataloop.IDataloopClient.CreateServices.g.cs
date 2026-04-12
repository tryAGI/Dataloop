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
        /// # Deploy service.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # :param str service_name: name<br/>
        /// # :param dtlpy.entities.package.Package package: package entity<br/>
        /// # :param str bot: bot email<br/>
        /// # :param str revision: package revision of version<br/>
        /// # :param init_input: config to run at startup<br/>
        /// # :param dict runtime: runtime resources<br/>
        /// # :param str pod_type: pod type dl.InstanceCatalog<br/>
        /// # :param str sdk_version:  - optional - string - sdk version<br/>
        /// # :param str agent_versions: - dictionary - - optional -versions of sdk<br/>
        /// # :param bool verify: if true, verify the inputs<br/>
        /// # :param bool checkout: if true, checkout (switch) to service<br/>
        /// # :param str module_name: module name<br/>
        /// # :param str project_id: project id<br/>
        /// # :param str driver_id: driver id<br/>
        /// # :param Callable func: function to deploy<br/>
        /// # :param bool run_execution_as_process: if true, run execution as process<br/>
        /// # :param int execution_timeout: execution timeout in seconds<br/>
        /// # :param int drain_time: drain time in seconds<br/>
        /// # :param int max_attempts: maximum execution retries in-case of a service reset<br/>
        /// # :param str on_reset: what happens on reset<br/>
        /// # :param bool force: optional - if true, terminate old replicas immediately<br/>
        /// # :param list secrets: list of the integrations ids<br/>
        /// # :param list integrations: list of the integrations<br/>
        /// # :param bool active: if true, activate the service<br/>
        /// # :param kwargs: list of additional arguments<br/>
        /// # :return: Service object<br/>
        /// # :rtype: dtlpy.entities.service.Service<br/>
        /// # <br/>
        /// # <br/>
        /// # service = package.services.deploy(service_name=package_name,<br/>
        /// # execution_timeout=3 * 60 * 60,<br/>
        /// # module_name=module.name,<br/>
        /// # runtime=dl.KubernetesRuntime(<br/>
        /// # concurrency=10,<br/>
        /// # pod_type=dl.InstanceCatalog.REGULAR_S,<br/>
        /// # autoscaler=dl.KubernetesRabbitmqAutoscaler(<br/>
        /// # min_replicas=1,<br/>
        /// # max_replicas=20,<br/>
        /// # queue_length=20<br/>
        /// # )<br/>
        /// # )<br/>
        /// # )<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task CreateServicesAsync(
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}