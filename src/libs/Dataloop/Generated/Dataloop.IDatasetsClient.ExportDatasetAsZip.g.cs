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
        global::System.Threading.Tasks.Task<string> ExportDatasetAsZipAsync(
            string id,

            global::Dataloop.ExportDatasetOptions request,
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}