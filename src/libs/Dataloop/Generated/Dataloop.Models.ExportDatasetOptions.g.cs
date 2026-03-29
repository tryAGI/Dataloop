
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Export dataset as zip file.<br/>
    /// items/annotations filters can be specified, only matching results will be included in zip.<br/>
    /// When specifying both items &amp; annotations filters - they will be joined.
    /// </summary>
    public sealed partial class ExportDatasetOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeItemVectors")]
        public bool? IncludeItemVectors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeAnnotationVectors")]
        public bool? IncludeAnnotationVectors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsVectorQuery")]
        public global::Dataloop.DQLResourceQuery? ItemsVectorQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationsVectorQuery")]
        public global::Dataloop.DQLResourceQuery? AnnotationsVectorQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsQuery")]
        public global::Dataloop.DQLResourceQuery? ItemsQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationsQuery")]
        public global::Dataloop.DQLResourceQuery? AnnotationsQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featureSetsQuery")]
        public global::Dataloop.DQLResourceQuery? FeatureSetsQuery { get; set; }

        /// <summary>
        /// annotations export options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::Dataloop.ExportDatasetOptionsAnnotations? Annotations { get; set; }

        /// <summary>
        /// `V2` - exported items will have original extension in filename, `V1` - no original extension in filenames
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ExportDatasetOptionsExportVersionJsonConverter))]
        public global::Dataloop.ExportDatasetOptionsExportVersion? ExportVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ExportTypeJsonConverter))]
        public global::Dataloop.ExportType? ExportType { get; set; }

        /// <summary>
        /// This flag is only honoured when exportType is 'json'. If zipJson is set to true the final json file is minified and zipped to reduce size
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zipJson")]
        public bool? ZipJson { get; set; }

        /// <summary>
        /// Determines whether the dataset should be locked during export.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetLock")]
        public bool? DatasetLock { get; set; }

        /// <summary>
        /// Intial state of the dataset readonly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetReadonlyInitialState")]
        public bool? DatasetReadonlyInitialState { get; set; }

        /// <summary>
        /// Determines the timeout seconds for dataset Lock*
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockTimeoutSec")]
        public double? LockTimeoutSec { get; set; }

        /// <summary>
        /// Determines whether summary file should be added to export<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public bool? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportDatasetOptions" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportDatasetOptions(
            bool? includeItemVectors,
            bool? includeAnnotationVectors,
            global::Dataloop.DQLResourceQuery? itemsVectorQuery,
            global::Dataloop.DQLResourceQuery? annotationsVectorQuery,
            global::Dataloop.DQLResourceQuery? itemsQuery,
            global::Dataloop.DQLResourceQuery? annotationsQuery,
            global::Dataloop.DQLResourceQuery? featureSetsQuery,
            global::Dataloop.ExportDatasetOptionsAnnotations? annotations,
            global::Dataloop.ExportDatasetOptionsExportVersion? exportVersion,
            global::Dataloop.ExportType? exportType,
            bool? zipJson,
            bool? datasetLock,
            bool? datasetReadonlyInitialState,
            double? lockTimeoutSec,
            bool? summary)
        {
            this.IncludeItemVectors = includeItemVectors;
            this.IncludeAnnotationVectors = includeAnnotationVectors;
            this.ItemsVectorQuery = itemsVectorQuery;
            this.AnnotationsVectorQuery = annotationsVectorQuery;
            this.ItemsQuery = itemsQuery;
            this.AnnotationsQuery = annotationsQuery;
            this.FeatureSetsQuery = featureSetsQuery;
            this.Annotations = annotations;
            this.ExportVersion = exportVersion;
            this.ExportType = exportType;
            this.ZipJson = zipJson;
            this.DatasetLock = datasetLock;
            this.DatasetReadonlyInitialState = datasetReadonlyInitialState;
            this.LockTimeoutSec = lockTimeoutSec;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportDatasetOptions" /> class.
        /// </summary>
        public ExportDatasetOptions()
        {
        }
    }
}