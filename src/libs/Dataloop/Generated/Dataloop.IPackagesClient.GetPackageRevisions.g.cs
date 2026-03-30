#nullable enable

namespace Dataloop
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Get package revisions by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get the package revision history.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.package.Package package: package entity<br/>
        /// # :param str package_id: package id<br/>
        /// # <br/>
        /// # <br/>
        /// # project.packages.revisions(package='package_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIPackage>> GetPackageRevisionsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}