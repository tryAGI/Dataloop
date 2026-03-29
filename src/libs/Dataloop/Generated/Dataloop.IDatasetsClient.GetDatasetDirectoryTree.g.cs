#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get a directory tree of the dataset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// directory_tree = dataset.directory_tree<br/>
        /// directory_tree = project.datasets.directory_tree(dataset='dataset_entity')<br/>
        /// # <br/>
        /// # Get dataset's directory tree.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: dataset, dataset_name, dataset_id.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.dataset.Dataset dataset: dataset object<br/>
        /// # :param str dataset_name: The Name of the dataset<br/>
        /// # :param str dataset_id: The Id of the dataset<br/>
        /// # :return: DirectoryTree<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.DatasetDirectoryTree> GetDatasetDirectoryTreeAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}