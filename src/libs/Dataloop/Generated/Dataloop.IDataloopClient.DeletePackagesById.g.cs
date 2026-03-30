#nullable enable

namespace Dataloop
{
    public partial interface IDataloopClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Delete a Package object.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.package.Package package: package entity<br/>
        /// # :param str package_id: package id<br/>
        /// # :param str package_name: package name<br/>
        /// # :return: True if success<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # project.packages.delete(package_name='package_name')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task DeletePackagesByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}