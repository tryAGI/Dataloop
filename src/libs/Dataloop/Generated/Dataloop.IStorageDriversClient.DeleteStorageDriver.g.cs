#nullable enable

namespace Dataloop
{
    public partial interface IStorageDriversClient
    {
        /// <summary>
        /// Delete storage driver<br/>
        /// NOTICE: datasets using the deleted driver will not be able to access storage after deletion
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// project.drivers.delete(dataset_id='dataset_id', sure=True, really=True)<br/>
        /// :param str driver_name: optional - search by name<br/>
        /// :param str driver_id: optional - search by id<br/>
        /// :param bool sure: Are you sure you want to delete?<br/>
        /// :param bool really: Really really sure?<br/>
        /// :return: True if success<br/>
        /// :rtype: bool<br/>
        /// # <br/>
        /// # Delete a driver forever!<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task DeleteStorageDriverAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}