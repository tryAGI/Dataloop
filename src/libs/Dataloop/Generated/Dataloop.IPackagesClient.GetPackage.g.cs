#nullable enable

namespace Dataloop
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Get package by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get Package object to use in your code.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param str package_id: package id<br/>
        /// # :param str package_name: package name<br/>
        /// # :param bool checkout: set the package as a default package object (cookies)<br/>
        /// # :param fetch: optional - fetch entity from platform, default taken from cookie<br/>
        /// # :param bool log_error: log error if package not found<br/>
        /// # :return: Package object<br/>
        /// # :rtype: dtlpy.entities.package.Package<br/>
        /// # <br/>
        /// # <br/>
        /// # project.packages.get(package_id='package_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPackage> GetPackageAsync(
            string id,
            string? version = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}