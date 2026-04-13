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
        /// # <br/>
        /// # project.packages.push(package_name='package_name',<br/>
        /// # modules=[module],<br/>
        /// # version='1.0.0',<br/>
        /// # src_path=os.getcwd()<br/>
        /// # )<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task CreatePackagesAsync(
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}