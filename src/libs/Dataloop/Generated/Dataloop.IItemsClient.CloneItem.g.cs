#nullable enable

namespace Dataloop
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Clone item. Read more about cloning datatsets and items in our `documentation &lt;https://dataloop.ai/docs/clone-merge-dataset#cloned-dataset&gt;`_ and `SDK documentation &lt;https://developers.dataloop.ai/tutorials/data_management/data_versioning/chapter/&gt;`_.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param str item_id: item to clone<br/>
        /// # :param str dst_dataset_id: destination dataset id<br/>
        /// # :param str remote_filepath: complete filepath<br/>
        /// # :param dict metadata: new metadata to add<br/>
        /// # :param bool with_annotations: clone annotations<br/>
        /// # :param bool with_metadata: clone metadata<br/>
        /// # :param bool with_task_annotations_status: clone task annotations status<br/>
        /// # :param bool allow_many: `bool` if True, using multiple clones in single dataset is allowed, (default=False)<br/>
        /// # :param bool wait: wait for the command to finish<br/>
        /// # :return: Item object<br/>
        /// # :rtype: dtlpy.entities.item.Item<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.items.clone(item_id='item_id',<br/>
        /// # dst_dataset_id='dist_dataset_id',<br/>
        /// # with_metadata=True,<br/>
        /// # with_task_annotations_status=False,<br/>
        /// # with_annotations=False)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> CloneItemAsync(
            string id,

            global::Dataloop.ItemCloneRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="targetDatasetId">
        /// Target dataset id
        /// </param>
        /// <param name="remoteFileName">
        /// path at target dataset
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="cloneDatasetParams"></param>
        /// <param name="allowMany">
        /// allow multiple copies of the same source item<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> CloneItemAsync(
            string id,
            string targetDatasetId,
            global::Dataloop.CloneDatasetParams cloneDatasetParams,
            string? remoteFileName = default,
            global::Dataloop.Dictionary? metadata = default,
            bool? allowMany = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}