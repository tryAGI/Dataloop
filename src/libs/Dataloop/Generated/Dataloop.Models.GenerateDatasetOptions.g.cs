
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateDatasetOptions
    {
        /// <summary>
        /// config id - used to identify a specific dataset generator output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// when specified - will be used for topic names, regardless of any conventions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::Dataloop.GenerateDatasetOptionsTopics? Topics { get; set; }

        /// <summary>
        /// number of items in generated dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dirsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DirsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDirDepth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxDirDepth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.GenerateDatasetOptionsMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::Dataloop.GenerateDatasetOptionsAnnotations? Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputStream")]
        public global::Dataloop.GenerateDatasetOptionsOutputStream? OutputStream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDatasetOptions" /> class.
        /// </summary>
        /// <param name="id">
        /// config id - used to identify a specific dataset generator output
        /// </param>
        /// <param name="itemsCount">
        /// number of items in generated dataset
        /// </param>
        /// <param name="dirsCount"></param>
        /// <param name="maxDirDepth"></param>
        /// <param name="metadata"></param>
        /// <param name="topics">
        /// when specified - will be used for topic names, regardless of any conventions
        /// </param>
        /// <param name="annotations"></param>
        /// <param name="outputStream"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateDatasetOptions(
            string id,
            double itemsCount,
            double dirsCount,
            double maxDirDepth,
            global::Dataloop.GenerateDatasetOptionsMetadata metadata,
            global::Dataloop.GenerateDatasetOptionsTopics? topics,
            global::Dataloop.GenerateDatasetOptionsAnnotations? annotations,
            global::Dataloop.GenerateDatasetOptionsOutputStream? outputStream)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Topics = topics;
            this.ItemsCount = itemsCount;
            this.DirsCount = dirsCount;
            this.MaxDirDepth = maxDirDepth;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Annotations = annotations;
            this.OutputStream = outputStream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDatasetOptions" /> class.
        /// </summary>
        public GenerateDatasetOptions()
        {
        }
    }
}