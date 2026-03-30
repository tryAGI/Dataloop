#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Clone a dataset. Read more about cloning datatsets and items in our `documentation &lt;https://dataloop.ai/docs/clone-merge-dataset#cloned-dataset&gt;`_ and `SDK documentation &lt;https://developers.dataloop.ai/tutorials/data_management/data_versioning/chapter/&gt;`_.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param str dataset_id: id of the dataset you wish to clone<br/>
        /// # :param str clone_name: new dataset name<br/>
        /// # :param dtlpy.entities.filters.Filters filters: Filters entity or a query dict<br/>
        /// # :param bool with_items_annotations: true to clone with items annotations<br/>
        /// # :param bool with_metadata: true to clone with metadata<br/>
        /// # :param bool with_task_annotations_status: true to clone with task annotations' status<br/>
        /// # :param str dst_dataset_id: destination dataset id<br/>
        /// # :param str target_directory: target directory<br/>
        /// # :return: dataset object<br/>
        /// # :rtype: dtlpy.entities.dataset.Dataset<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset = project.datasets.clone(dataset_id='dataset_id',<br/>
        /// # clone_name='dataset_clone_name',<br/>
        /// # with_metadata=True,<br/>
        /// # with_items_annotations=False,<br/>
        /// # with_task_annotations_status=False)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> CloneDatasetAsync(
            string id,

            global::Dataloop.CloneDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// Dataset name
        /// </param>
        /// <param name="filter"></param>
        /// <param name="cloneDatasetParams"></param>
        /// <param name="returnCmd">
        /// run as async
        /// </param>
        /// <param name="version"></param>
        /// <param name="indexDriver"></param>
        /// <param name="allowAnnotationDuplication"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> CloneDatasetAsync(
            string id,
            string name,
            global::Dataloop.DQLQuery filter,
            global::Dataloop.CloneDatasetParams cloneDatasetParams,
            bool? returnCmd = default,
            double? version = default,
            global::Dataloop.DatasetIndexDrivers? indexDriver = default,
            bool? allowAnnotationDuplication = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}