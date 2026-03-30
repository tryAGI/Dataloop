#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Update service changes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update service changes to platform.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.service.Service service: Service entity<br/>
        /// # :param bool force: optional - terminate old replicas immediately<br/>
        /// # :return: Service entity<br/>
        /// # :rtype: dtlpy.entities.service.Service<br/>
        /// # <br/>
        /// # <br/>
        /// # service = package.services.update(service='service_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIService, string>> UpdateServiceAsync(
            string id,

            global::Dataloop.APIServicePatch request,
            string? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update service changes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="packageRevision"></param>
        /// <param name="initParams"></param>
        /// <param name="runtime"></param>
        /// <param name="useUserJwt"></param>
        /// <param name="versions"></param>
        /// <param name="moduleName"></param>
        /// <param name="global"></param>
        /// <param name="active"></param>
        /// <param name="runExecutionAsProcess"></param>
        /// <param name="executionTimeout"></param>
        /// <param name="drainTime"></param>
        /// <param name="onReset"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="version"></param>
        /// <param name="botUserName"></param>
        /// <param name="driverId"></param>
        /// <param name="secrets"></param>
        /// <param name="type"></param>
        /// <param name="mode"></param>
        /// <param name="metadata"></param>
        /// <param name="panels"></param>
        /// <param name="packageId"></param>
        /// <param name="packageName"></param>
        /// <param name="archive"></param>
        /// <param name="displayName"></param>
        /// <param name="app"></param>
        /// <param name="integrations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIService, string>> UpdateServiceAsync(
            string id,
            string? force = default,
            string? packageRevision = default,
            object? initParams = default,
            global::Dataloop.ServiceRuntime? runtime = default,
            bool? useUserJwt = default,
            global::Dataloop.ServiceVersions? versions = default,
            string? moduleName = default,
            bool? global = default,
            bool? active = default,
            bool? runExecutionAsProcess = default,
            double? executionTimeout = default,
            double? drainTime = default,
            string? onReset = default,
            double? maxAttempts = default,
            string? version = default,
            string? botUserName = default,
            string? driverId = default,
            global::System.Collections.Generic.IList<string>? secrets = default,
            global::Dataloop.ServiceType? type = default,
            global::Dataloop.ServiceMode? mode = default,
            global::Dataloop.ServiceMetadata? metadata = default,
            global::System.Collections.Generic.IList<global::Dataloop.Panel>? panels = default,
            string? packageId = default,
            string? packageName = default,
            bool? archive = default,
            string? displayName = default,
            global::Dataloop.IAppDefinition? app = default,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? integrations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}