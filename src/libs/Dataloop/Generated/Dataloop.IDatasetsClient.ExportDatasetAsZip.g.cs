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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Export dataset items and annotations.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: dataset, dataset_name, dataset_id.<br/>
        /// # <br/>
        /// # **Export Behavior by Parameter Combination:**<br/>
        /// # <br/>
        /// # The behavior of this method depends on the combination of `export_type` and `output_export_type`:<br/>
        /// # <br/>
        /// # **When export_type = ExportType.JSON:**<br/>
        /// # <br/>
        /// # - **output_export_type = OutputExportType.JSON (default when None):**<br/>
        /// # - Exports data in JSON format, split into subsets of max 500 items<br/>
        /// # - Downloads all subset JSON files and concatenates them into a single `result.json` file<br/>
        /// # - Returns the path to the concatenated JSON file<br/>
        /// # - Cleans up individual subset files after concatenation<br/>
        /// # <br/>
        /// # - **output_export_type = OutputExportType.ZIP:**<br/>
        /// # - Same as JSON export, but zips the final `result.json` file<br/>
        /// # - Returns the path to the zipped file (`result.json.zip`)<br/>
        /// # - Cleans up the unzipped JSON file after zipping<br/>
        /// # <br/>
        /// # - **output_export_type = OutputExportType.FOLDERS:**<br/>
        /// # - Exports data in JSON format, split into subsets of max 500 items<br/>
        /// # - Downloads all subset JSON files and creates individual JSON files for each item<br/>
        /// # - Creates a folder structure mirroring the remote dataset structure<br/>
        /// # - Returns the path to the base directory containing the folder structure<br/>
        /// # - Each item gets its own JSON file named after the original filename<br/>
        /// # <br/>
        /// # **When export_type = ExportType.ZIP:**<br/>
        /// # <br/>
        /// # - **output_export_type = OutputExportType.ZIP:**<br/>
        /// # - Exports data as a ZIP file containing the dataset<br/>
        /// # - Returns the downloaded ZIP item directly<br/>
        /// # - No additional processing or concatenation<br/>
        /// # <br/>
        /// # - **output_export_type = OutputExportType.JSON:**<br/>
        /// # - **NOT SUPPORTED** - Raises NotImplementedError<br/>
        /// # - Use export_type=ExportType.JSON instead for JSON output<br/>
        /// # <br/>
        /// # - **output_export_type = OutputExportType.FOLDERS:**<br/>
        /// # - **NOT SUPPORTED** - Raises NotImplementedError<br/>
        /// # - Use export_type=ExportType.JSON instead for folder output<br/>
        /// # <br/>
        /// # **When output_export_type = None (legacy behavior):**<br/>
        /// # - Defaults to OutputExportType.JSON<br/>
        /// # - Maintains backward compatibility with existing code<br/>
        /// # <br/>
        /// # :param dtlpy.entities.dataset.Dataset dataset: Dataset object<br/>
        /// # :param str dataset_name: The name of the dataset<br/>
        /// # :param str dataset_id: The ID of the dataset<br/>
        /// # :param str local_path: Local path to save the exported dataset<br/>
        /// # :param Union[dict, dtlpy.entities.filters.Filters] filters: Filters entity or a query dictionary<br/>
        /// # :param dtlpy.entities.filters.Filters annotation_filters: Filters entity to filter annotations for export<br/>
        /// # :param dtlpy.entities.filters.Filters feature_vector_filters: Filters entity to filter feature vectors for export<br/>
        /// # :param bool include_feature_vectors: Include item feature vectors in the export<br/>
        /// # :param bool include_annotations: Include item annotations in the export<br/>
        /// # :param bool dataset_lock: Make dataset readonly during the export<br/>
        /// # :param bool export_summary: Get Summary of the dataset export<br/>
        /// # :param int lock_timeout_sec: Timeout for locking the dataset during export in seconds<br/>
        /// # :param entities.ExportType export_type: Type of export ('json' or 'zip')<br/>
        /// # :param entities.OutputExportType output_export_type: Output format ('json', 'zip', or 'folders'). If None, defaults to 'json'<br/>
        /// # :param int timeout: Maximum time in seconds to wait for the export to complete<br/>
        /// # :return: Path to exported file/directory, or None if export result is empty<br/>
        /// # :rtype: Optional[str]<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<string> ExportDatasetAsZipAsync(
            string id,

            global::Dataloop.ExportDatasetOptions request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeItemVectors"></param>
        /// <param name="includeAnnotationVectors"></param>
        /// <param name="itemsVectorQuery"></param>
        /// <param name="annotationsVectorQuery"></param>
        /// <param name="itemsQuery"></param>
        /// <param name="annotationsQuery"></param>
        /// <param name="featureSetsQuery"></param>
        /// <param name="annotations">
        /// annotations export options
        /// </param>
        /// <param name="exportVersion">
        /// `V2` - exported items will have original extension in filename, `V1` - no original extension in filenames
        /// </param>
        /// <param name="exportType"></param>
        /// <param name="zipJson">
        /// This flag is only honoured when exportType is 'json'. If zipJson is set to true the final json file is minified and zipped to reduce size
        /// </param>
        /// <param name="datasetLock">
        /// Determines whether the dataset should be locked during export.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="datasetReadonlyInitialState">
        /// Intial state of the dataset readonly
        /// </param>
        /// <param name="lockTimeoutSec">
        /// Determines the timeout seconds for dataset Lock*
        /// </param>
        /// <param name="summary">
        /// Determines whether summary file should be added to export<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExportDatasetAsZipAsync(
            string id,
            bool? includeItemVectors = default,
            bool? includeAnnotationVectors = default,
            global::Dataloop.DQLResourceQuery? itemsVectorQuery = default,
            global::Dataloop.DQLResourceQuery? annotationsVectorQuery = default,
            global::Dataloop.DQLResourceQuery? itemsQuery = default,
            global::Dataloop.DQLResourceQuery? annotationsQuery = default,
            global::Dataloop.DQLResourceQuery? featureSetsQuery = default,
            global::Dataloop.ExportDatasetOptionsAnnotations? annotations = default,
            global::Dataloop.ExportDatasetOptionsExportVersion? exportVersion = default,
            global::Dataloop.ExportType? exportType = default,
            bool? zipJson = default,
            bool? datasetLock = default,
            bool? datasetReadonlyInitialState = default,
            double? lockTimeoutSec = default,
            bool? summary = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}