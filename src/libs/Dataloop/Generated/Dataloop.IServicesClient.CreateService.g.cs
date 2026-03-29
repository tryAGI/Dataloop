#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Create new package.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// service = package.services.deploy(service_name=package_name,<br/>
        /// execution_timeout=3 * 60 * 60,<br/>
        /// module_name=module.name,<br/>
        /// runtime=dl.KubernetesRuntime(<br/>
        /// concurrency=10,<br/>
        /// pod_type=dl.InstanceCatalog.REGULAR_S,<br/>
        /// autoscaler=dl.KubernetesRabbitmqAutoscaler(<br/>
        /// min_replicas=1,<br/>
        /// max_replicas=20,<br/>
        /// queue_length=20<br/>
        /// )<br/>
        /// )<br/>
        /// )<br/>
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
        /// # :param kwargs: list of additional arguments<br/>
        /// # :return: Service object<br/>
        /// # :rtype: dtlpy.entities.service.Service<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIService> CreateServiceAsync(

            global::Dataloop.APIService request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new package.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="packageId"></param>
        /// <param name="appId"></param>
        /// <param name="packageRevision"></param>
        /// <param name="initParams"></param>
        /// <param name="runtime"></param>
        /// <param name="useUserJwt"></param>
        /// <param name="botUserName"></param>
        /// <param name="versions"></param>
        /// <param name="moduleName"></param>
        /// <param name="global"></param>
        /// <param name="active"></param>
        /// <param name="runExecutionAsProcess"></param>
        /// <param name="executionTimeout"></param>
        /// <param name="drainTime"></param>
        /// <param name="onReset"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="driverId"></param>
        /// <param name="version"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="secrets"></param>
        /// <param name="panels"></param>
        /// <param name="config"></param>
        /// <param name="type"></param>
        /// <param name="crashloop"></param>
        /// <param name="mode"></param>
        /// <param name="metadata"></param>
        /// <param name="updatedBy"></param>
        /// <param name="archive"></param>
        /// <param name="settings"></param>
        /// <param name="displayName"></param>
        /// <param name="app"></param>
        /// <param name="integrations"></param>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIService> CreateServiceAsync(
            string id,
            string url,
            string packageId,
            object initParams,
            global::Dataloop.ServiceRuntime runtime,
            bool useUserJwt,
            string botUserName,
            global::Dataloop.ServiceVersions versions,
            string moduleName,
            bool runExecutionAsProcess,
            double executionTimeout,
            double drainTime,
            global::Dataloop.OnResetAction onReset,
            string name,
            string projectId,
            string driverId,
            string version,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string creator,
            string? appId = default,
            string? packageRevision = default,
            bool? global = default,
            bool? active = default,
            double? maxAttempts = default,
            global::System.Collections.Generic.IList<string>? secrets = default,
            global::System.Collections.Generic.IList<global::Dataloop.Panel>? panels = default,
            global::Dataloop.IServiceAppConfig? config = default,
            global::Dataloop.ServiceType? type = default,
            global::Dataloop.Crashloop? crashloop = default,
            global::Dataloop.ServiceMode? mode = default,
            global::Dataloop.ServiceMetadata? metadata = default,
            string? updatedBy = default,
            bool? archive = default,
            global::Dataloop.IServiceGeneralSettings? settings = default,
            string? displayName = default,
            global::Dataloop.IAppDefinition? app = default,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? integrations = default,
            string? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}