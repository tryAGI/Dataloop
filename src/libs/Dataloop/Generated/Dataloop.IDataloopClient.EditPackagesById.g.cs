#nullable enable

namespace Dataloop
{
    public partial interface IDataloopClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
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
        global::System.Threading.Tasks.Task EditPackagesByIdAsync(
            string id,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}