
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricRequest
    {
        /// <summary>
        /// The model the metric was generated on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// The dataset the metric was generated on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// The figure of the metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("figure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Figure { get; set; }

        /// <summary>
        /// The legend of the metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legend")]
        public string? Legend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.MetricDataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.MetricData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricRequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The model the metric was generated on
        /// </param>
        /// <param name="figure">
        /// The figure of the metric
        /// </param>
        /// <param name="data"></param>
        /// <param name="datasetId">
        /// The dataset the metric was generated on
        /// </param>
        /// <param name="legend">
        /// The legend of the metric
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricRequest(
            string modelId,
            string figure,
            global::Dataloop.MetricData data,
            string? datasetId,
            string? legend)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.DatasetId = datasetId;
            this.Figure = figure ?? throw new global::System.ArgumentNullException(nameof(figure));
            this.Legend = legend;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricRequest" /> class.
        /// </summary>
        public MetricRequest()
        {
        }
    }
}