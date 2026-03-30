#nullable enable

namespace Dataloop
{
    public partial interface IStorageDriversClient
    {
        /// <summary>
        /// Get storage driver configuration
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get a Driver object to use in your code.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: driver_name, driver_id.<br/>
        /// # <br/>
        /// # :param str driver_name: optional - search by name<br/>
        /// # :param str driver_id: optional - search by id<br/>
        /// # :return: Driver object<br/>
        /// # :rtype: dtlpy.entities.driver.Driver<br/>
        /// # <br/>
        /// # <br/>
        /// # project.drivers.get(driver_id='driver_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDriverConfiguration> GetStorageDriverAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}