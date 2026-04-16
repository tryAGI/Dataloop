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
        /// # **Export Versions:**<br/>
        /// # <br/>
        /// # - **DatasetExportVersion.V1** (default): Legacy export API using item-based commands<br/>
        /// # - **DatasetExportVersion.V3**: LanceDB-based export with partitioned NDJSON output and<br/>
        /// # support for incremental (diff) exports<br/>
        /// # <br/>
        /// # **V1 Export Behavior (export_version=DatasetExportVersion.V1):**<br/>
        /// # <br/>
        /// # The behavior depends on the combination of `export_type` and `output_export_type`:<br/>
        /// # <br/>
        /// # **When export_type = ExportType.JSON:**<br/>
        /// # <br/>
        /// # - **output_export_type = OutputExportType.JSON (default when None):**<br/>
        /// # - Exports data in JSON format, split into subsets of max 500 items<br/>
        /// # - Downloads all subset JSON files and concatenates them into a single `result.json` file<br/>
        /// # - Returns the path to the concatenated JSON file<br/>
        /// # <br/>
        /// # - **output_export_type = OutputExportType.ZIP:**<br/>
        /// # - Same as JSON export, but zips the final `result.json` file<br/>
        /// # - Returns the path to the zipped file (`result.json.zip`)<br/>
        /// # <br/>
        /// # - **output_export_type = OutputExportType.FOLDERS:**<br/>
        /// # - Creates a folder structure mirroring the remote dataset structure<br/>
        /// # - Each item gets its own JSON file named after the original filename<br/>
        /// # <br/>
        /// # **When export_type = ExportType.ZIP:**<br/>
        /// # - Exports data as a ZIP file containing the dataset<br/>
        /// # - Returns the downloaded ZIP item directly<br/>
        /// # <br/>
        /// # **V3 Export Behavior (export_version=DatasetExportVersion.V3):**<br/>
        /// # <br/>
        /// # - **export_mode = ExportMode.FULL**: Exports all items matching filters (default)<br/>
        /// # - **export_mode = ExportMode.DIFF**: Exports only items changed since `from_version`<br/>
        /// # - Returns an ExportManifest object with partition info and downloaded file paths<br/>
        /// # <br/>
        /// # :param dtlpy.entities.dataset.Dataset dataset: Dataset object<br/>
        /// # :param str dataset_name: The name of the dataset<br/>
        /// # :param str dataset_id: The ID of the dataset<br/>
        /// # :param str local_path: Local directory path to save the exported dataset. Must be a directory, not a file path.<br/>
        /// # :param Union[dict, dtlpy.entities.filters.Filters] filters: Filters entity or a query dictionary<br/>
        /// # :param dtlpy.entities.filters.Filters annotation_filters: Filters entity to filter annotations (V1 only)<br/>
        /// # :param dtlpy.entities.filters.Filters feature_vector_filters: Filters entity to filter feature vectors (V1 only)<br/>
        /// # :param bool include_feature_vectors: Include item feature vectors in the export (V1 only)<br/>
        /// # :param bool include_annotations: Include item annotations in the export (V1 only)<br/>
        /// # :param bool dataset_lock: Make dataset readonly during the export (V1 only)<br/>
        /// # :param bool export_summary: Get Summary of the dataset export (V1 only)<br/>
        /// # :param int lock_timeout_sec: Timeout for locking the dataset during export in seconds (V1 only)<br/>
        /// # :param entities.ExportType export_type: Type of export ('json' or 'zip') (V1 only)<br/>
        /// # :param entities.OutputExportType output_export_type: Output format ('json', 'zip', or 'folders') (V1 only)<br/>
        /// # :param int timeout: Maximum time in seconds to wait for the export to complete<br/>
        /// # :param entities.DatasetExportVersion export_version: Export API version - V1 (legacy) or V3 (LanceDB)<br/>
        /// # :param entities.ExportMode export_mode: Export mode for V3 - FULL or DIFF (V3 only)<br/>
        /// # :param int from_version: Starting version for diff mode (V3 only). If not provided in DIFF mode,<br/>
        /// # falls back to last_to_version from dataset metadata. If no previous export exists, falls back to FULL mode.<br/>
        /// # :param int partition_count: Number of partitions, auto-calculated if None (V3 only)<br/>
        /// # :param bool force: Force re-export even if cached (V3 only)<br/>
        /// # :param int parallel_downloads: Number of concurrent partition downloads (V3 only)<br/>
        /// # :return: For V1: Path to exported file/directory, or None if empty. For V3: ExportManifest object<br/>
        /// # :rtype: Union[Optional[str], entities.ExportManifest]<br/>
        /// # <br/>
        /// # **Example - V1 Export (Legacy)**:<br/>
        /// # <br/>
        /// # # Default V1 export<br/>
        /// # export_path = dataset.export(<br/>
        /// # local_path='/path/to/export',<br/>
        /// # export_type=dl.ExportType.JSON<br/>
        /// # )<br/>
        /// # <br/>
        /// # **Example - V3 Export (LanceDB)**:<br/>
        /// # <br/>
        /// # # Full V3 export<br/>
        /// # manifest = dataset.export(<br/>
        /// # local_path='/path/to/export',<br/>
        /// # export_version=dl.DatasetExportVersion.V3,<br/>
        /// # export_mode=dl.ExportMode.FULL<br/>
        /// # )<br/>
        /// # print(f"Exported {manifest.total_records} records")<br/>
        /// # <br/>
        /// # **Example - V3 Diff Export (Incremental)**:<br/>
        /// # <br/>
        /// # # Incremental export - only changes since version 5<br/>
        /// # manifest = dataset.export(<br/>
        /// # export_version=dl.DatasetExportVersion.V3,<br/>
        /// # export_mode=dl.ExportMode.DIFF,<br/>
        /// # from_version=5<br/>
        /// # )<br/>
        /// # # Store to_version for next diff export<br/>
        /// # next_from_version = manifest.to_version<br/>
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