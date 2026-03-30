#nullable enable

namespace Dataloop
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get Item object<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param str filepath: optional - search by remote path<br/>
        /// # :param str item_id: optional - search by id<br/>
        /// # :param bool fetch: optional - fetch entity from platform, default taken from cookie<br/>
        /// # :param bool is_dir: True if you want to get an item from dir type<br/>
        /// # :return: Item object<br/>
        /// # :rtype: dtlpy.entities.item.Item<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.items.get(item_id='item_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>> GetItemAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}