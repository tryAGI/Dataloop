
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateModelMetricsReportRequest
    {
        /// <summary>
        /// The dataset or datasets to generate report for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetIds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? DatasetIds { get; set; }

        /// <summary>
        /// The models to generate report for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelIds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>> ModelIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateModelMetricsReportRequest" /> class.
        /// </summary>
        /// <param name="modelIds">
        /// The models to generate report for
        /// </param>
        /// <param name="datasetIds">
        /// The dataset or datasets to generate report for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateModelMetricsReportRequest(
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>> modelIds,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? datasetIds)
        {
            this.DatasetIds = datasetIds;
            this.ModelIds = modelIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateModelMetricsReportRequest" /> class.
        /// </summary>
        public GenerateModelMetricsReportRequest()
        {
        }
    }
}