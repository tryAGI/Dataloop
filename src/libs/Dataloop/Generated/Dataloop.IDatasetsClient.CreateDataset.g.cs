#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create a new dataset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create a new dataset<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param str dataset_name: The Name of the dataset<br/>
        /// # :param list labels: dictionary of {tag: color} or list of label entities<br/>
        /// # :param list attributes: dataset's ontology's attributes<br/>
        /// # :param list ontology_ids: optional - dataset ontology<br/>
        /// # :param dtlpy.entities.driver.Driver driver: optional - storage driver Driver object or driver name<br/>
        /// # :param str driver_id: optional - driver id<br/>
        /// # :param bool checkout: set the dataset as a default dataset object (cookies)<br/>
        /// # :param ExpirationOptions expiration_options: dl.ExpirationOptions object that contain definitions for dataset like MaxItemDays<br/>
        /// # :param str index_driver: dl.IndexDriver, dataset driver version<br/>
        /// # :param str recipe_id: optional - recipe id<br/>
        /// # :return: Dataset object<br/>
        /// # :rtype: dtlpy.entities.dataset.Dataset<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset = project.datasets.create(dataset_name='dataset_name', ontology_ids='ontology_ids')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDataset> CreateDatasetAsync(

            global::Dataloop.CreateDatasetRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new dataset
        /// </summary>
        /// <param name="name">
        /// Dataset name
        /// </param>
        /// <param name="projects">
        /// list of project ids related to the created dataset
        /// </param>
        /// <param name="driver">
        /// Driver type of an existing driver or new driver configuration
        /// </param>
        /// <param name="driverId">
        /// Driver id of an existing external driver
        /// </param>
        /// <param name="accessLevel">
        /// Share options, only user or all project members with the right role (default is project)
        /// </param>
        /// <param name="createDefaultRecipe"></param>
        /// <param name="expirationOptions"></param>
        /// <param name="indexDriver"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDataset> CreateDatasetAsync(
            string name,
            global::System.Collections.Generic.IList<string> projects,
            global::Dataloop.CreateDatasetRequestDriver? driver = default,
            string? driverId = default,
            global::Dataloop.CreateDatasetRequestAccessLevel? accessLevel = default,
            bool? createDefaultRecipe = default,
            global::Dataloop.ExpirationOptions? expirationOptions = default,
            global::Dataloop.IndexDriver? indexDriver = default,
            global::Dataloop.DatasetMetadata? metadata = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}