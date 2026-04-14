#nullable enable

namespace Dataloop
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Update package changes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update Package changes to the platform.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.package.Package package:<br/>
        /// # :param revision_increment: optional - str - version bumping method - major/minor/patch - default = None<br/>
        /// # :return: Package object<br/>
        /// # :rtype: dtlpy.entities.package.Package<br/>
        /// # <br/>
        /// # <br/>
        /// # project.packages.delete(package='package_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPackage> UpdatePackageAsync(
            string id,

            global::Dataloop.APIPackage request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update package changes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="url"></param>
        /// <param name="version"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="updatedBy"></param>
        /// <param name="name"></param>
        /// <param name="global"></param>
        /// <param name="projectId"></param>
        /// <param name="codebase"></param>
        /// <param name="modules"></param>
        /// <param name="uiHooks"></param>
        /// <param name="slots"></param>
        /// <param name="serviceConfig"></param>
        /// <param name="type"></param>
        /// <param name="requirements"></param>
        /// <param name="metadata"></param>
        /// <param name="panels"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPackage> UpdatePackageAsync(
            string id,
            string requestId,
            string url,
            string version,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string creator,
            string updatedBy,
            string name,
            bool global,
            string projectId,
            global::Dataloop.Codebase codebase,
            global::System.Collections.Generic.IList<global::Dataloop.Module> modules,
            global::Dataloop.PackageType type,
            global::System.Collections.Generic.IList<global::Dataloop.UiHook>? uiHooks = default,
            global::System.Collections.Generic.IList<global::Dataloop.PiperUiSlot>? slots = default,
            global::Dataloop.ServiceConfig? serviceConfig = default,
            global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>? requirements = default,
            global::Dataloop.PackageMetadata? metadata = default,
            global::System.Collections.Generic.IList<global::Dataloop.Panel>? panels = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}