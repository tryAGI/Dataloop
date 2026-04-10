#nullable enable

namespace Dataloop
{
    public partial interface IItemsClient
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
        /// # Delete item from platform.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: item id, filename, filters.<br/>
        /// # <br/>
        /// # :param str filename: optional - search item by remote path<br/>
        /// # :param str item_id: optional - search item by id<br/>
        /// # :param dtlpy.entities.filters.Filters filters: optional - delete items by filter<br/>
        /// # :return: True if success<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.items.delete(item_id='item_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task RemoveItemAsync(
            string id,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}