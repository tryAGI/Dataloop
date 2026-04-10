#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete a dataset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="targetDeleteDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Delete a dataset forever!<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # <br/>
        /// # is_deleted = project.datasets.delete(dataset_id='dataset_id', sure=True, really=True)<br/>
        /// # <br/>
        /// # :param str dataset_name: optional - search by name<br/>
        /// # :param str dataset_id: optional - search by id<br/>
        /// # :param bool sure: Are you sure you want to delete?<br/>
        /// # :param bool really: Really really sure?<br/>
        /// # :return: True is success<br/>
        /// # :rtype: bool<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<double> DeleteDatasetAsync(
            string id,
            bool? force = default,
            global::System.DateTime? targetDeleteDate = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}