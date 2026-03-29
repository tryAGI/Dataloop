
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrecisionRecallInputRequest
    {
        /// <summary>
        /// The model that calculated on it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// The dataset that calculated on it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// The iouThreshold of the calculation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iouThreshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IouThreshold { get; set; }

        /// <summary>
        /// The metric to calculation the confusion Matrix
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        public string? Metric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrecisionRecallInputRequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The model that calculated on it
        /// </param>
        /// <param name="datasetId">
        /// The dataset that calculated on it
        /// </param>
        /// <param name="iouThreshold">
        /// The iouThreshold of the calculation
        /// </param>
        /// <param name="metric">
        /// The metric to calculation the confusion Matrix
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrecisionRecallInputRequest(
            string modelId,
            string datasetId,
            double iouThreshold,
            string? metric)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.IouThreshold = iouThreshold;
            this.Metric = metric;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrecisionRecallInputRequest" /> class.
        /// </summary>
        public PrecisionRecallInputRequest()
        {
        }
    }
}