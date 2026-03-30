#nullable enable

namespace Dataloop
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="system"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update item metadata.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: update_values, system_update_values.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.item.Item item: Item object<br/>
        /// # :param dtlpy.entities.filters.Filters filters: optional update filtered items by given filter<br/>
        /// # :param update_values: optional field to be updated and new values<br/>
        /// # :param system_update_values: values in system metadata to be updated<br/>
        /// # :param bool system_metadata: True, if you want to update the metadata system<br/>
        /// # :return: Item object<br/>
        /// # :rtype: dtlpy.entities.item.Item<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.items.update(item='item_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>> EditItemAsync(
            string id,

            global::Dataloop.PartialAPIDatasetItem request,
            bool? system = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="system"></param>
        /// <param name="filename"></param>
        /// <param name="description"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>> EditItemAsync(
            string id,
            bool? system = default,
            string? filename = default,
            string? description = default,
            global::Dataloop.APISystemMetadata? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}