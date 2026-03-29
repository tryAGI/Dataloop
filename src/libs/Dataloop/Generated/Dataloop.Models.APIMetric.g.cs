
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.MetricDataTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.MetricDataTypes Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.EntityContext Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIMetric" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="modelId">
        /// The model the metric was generated on
        /// </param>
        /// <param name="datasetId">
        /// The dataset the metric was generated on
        /// </param>
        /// <param name="figure">
        /// The figure of the metric
        /// </param>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="context"></param>
        /// <param name="legend">
        /// The legend of the metric
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIMetric(
            string id,
            string url,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string modelId,
            string datasetId,
            string figure,
            global::Dataloop.MetricData data,
            global::Dataloop.MetricDataTypes type,
            global::Dataloop.EntityContext context,
            string? legend)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.Figure = figure ?? throw new global::System.ArgumentNullException(nameof(figure));
            this.Legend = legend;
            this.Data = data;
            this.Type = type;
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIMetric" /> class.
        /// </summary>
        public APIMetric()
        {
        }
    }
}