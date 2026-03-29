#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// success = project.datasets.merge(dataset_ids=['dataset_id1','dataset_id2'],<br/>
        /// merge_name='dataset_merge_name',<br/>
        /// with_metadata=True,<br/>
        /// with_items_annotations=False,<br/>
        /// with_task_annotations_status=False)<br/>
        /// # <br/>
        /// # Merge a dataset. See our `SDK docs &lt;https://developers.dataloop.ai/tutorials/data_management/data_versioning/chapter/&gt;`_ for more information.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param str merge_name: new dataset name<br/>
        /// # :param list dataset_ids: list id's of the datatsets you wish to merge<br/>
        /// # :param str project_ids: the project id that include the datasets<br/>
        /// # :param bool with_items_annotations: true to merge with items annotations<br/>
        /// # :param bool with_metadata: true to merge with metadata<br/>
        /// # :param bool with_task_annotations_status: true to merge with task annotations' status<br/>
        /// # :param bool wait: wait for the command to finish<br/>
        /// # :return: True if success<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> MergeDatasetsAsync(

            global::Dataloop.MergeDatasetsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">
        /// Dataset name
        /// </param>
        /// <param name="datasetsIds">
        /// datasets id's
        /// </param>
        /// <param name="mergeDatasetParams"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> MergeDatasetsAsync(
            string name,
            global::System.Collections.Generic.IList<string> datasetsIds,
            global::Dataloop.MergeDatasetParams mergeDatasetParams,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}