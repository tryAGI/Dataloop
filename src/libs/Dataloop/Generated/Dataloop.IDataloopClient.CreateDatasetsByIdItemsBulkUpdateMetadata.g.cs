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
        /// # Bulk update ML subset assignment for selected items.<br/>
        /// # If subset is None, remove subsets. Otherwise, assign the specified subset.<br/>
        /// # <br/>
        /// # :param str dataset_id: ID of the dataset<br/>
        /// # :param dict items_query: DQLResourceQuery (filters) for selecting items<br/>
        /// # :param str subset: 'train', 'validation', 'test' or None to remove all<br/>
        /// # :return: True if success<br/>
        /// # :rtype: bool<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task CreateDatasetsByIdItemsBulkUpdateMetadataAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}