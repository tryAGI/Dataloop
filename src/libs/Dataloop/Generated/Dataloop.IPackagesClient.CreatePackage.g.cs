#nullable enable

namespace Dataloop
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Create new package.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// project.packages.push(package_name='package_name',<br/>
        /// modules=[module],<br/>
        /// version='1.0.0',<br/>
        /// src_path=os.getcwd()<br/>
        /// )<br/>
        /// # <br/>
        /// # Push your local package to the UI.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # Project will be taken in the following hierarchy:<br/>
        /// # project(input) -&gt; project_id(input) -&gt; self.project(context) -&gt; checked out<br/>
        /// # <br/>
        /// # :param dtlpy.entities.project.Project project: optional - project entity to deploy to. default from context or checked-out<br/>
        /// # :param str project_id: optional - project id to deploy to. default from context or checked-out<br/>
        /// # :param str package_name: package name<br/>
        /// # :param str src_path: path to package codebase<br/>
        /// # :param dtlpy.entities.codebase.Codebase codebase: codebase object<br/>
        /// # :param list modules: list of modules PackageModules of the package<br/>
        /// # :param bool is_global: is package is global or local<br/>
        /// # :param bool checkout: checkout package to local dir<br/>
        /// # :param str revision_increment: optional - str - version bumping method - major/minor/patch - default = None<br/>
        /// # :param str version: semver version f the package<br/>
        /// # :param bool ignore_sanity_check: NOT RECOMMENDED - skip code sanity check before pushing<br/>
        /// # :param bool service_update: optional - bool - update the service<br/>
        /// # :param dict service_config : Service object as dict. Contains the spec of the default service to create.<br/>
        /// # :param list slots: optional - list of slots PackageSlot of the package<br/>
        /// # :param list requirements: requirements - list of package requirements<br/>
        /// # :param str package_type: default 'faas', options: 'app', 'ml<br/>
        /// # :param dict metadata: dictionary of system and user metadata<br/>
        /// # <br/>
        /// # :return: Package object<br/>
        /// # :rtype: dtlpy.entities.package.Package<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPackage> CreatePackageAsync(

            global::Dataloop.APIPackage request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new package.
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPackage> CreatePackageAsync(
            string id,
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}