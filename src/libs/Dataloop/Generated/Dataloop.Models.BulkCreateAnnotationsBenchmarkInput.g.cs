
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkCreateAnnotationsBenchmarkInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public double? Concurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("childCount")]
        public double? ChildCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationsPerItem")]
        public double? AnnotationsPerItem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateAnnotationsBenchmarkInput" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="concurrency"></param>
        /// <param name="childCount"></param>
        /// <param name="annotationsPerItem"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkCreateAnnotationsBenchmarkInput(
            string datasetId,
            double? concurrency,
            double? childCount,
            double? annotationsPerItem)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.Concurrency = concurrency;
            this.ChildCount = childCount;
            this.AnnotationsPerItem = annotationsPerItem;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateAnnotationsBenchmarkInput" /> class.
        /// </summary>
        public BulkCreateAnnotationsBenchmarkInput()
        {
        }
    }
}