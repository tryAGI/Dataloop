#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get a specific Dataset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// dataset = project.datasets.get(dataset_id='dataset_id')<br/>
        /// # <br/>
        /// # Get dataset by name or id.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: dataset_id, dataset_name.<br/>
        /// # <br/>
        /// # :param str dataset_name: optional - search by name<br/>
        /// # :param str dataset_id: optional - search by id<br/>
        /// # :param bool checkout: set the dataset as a default dataset object (cookies)<br/>
        /// # :param bool fetch: optional - fetch entity from platform (True), default taken from cookie<br/>
        /// # :return: Dataset object<br/>
        /// # :rtype: dtlpy.entities.dataset.Dataset<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDataset> GetDatasetByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}