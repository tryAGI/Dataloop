
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddAnnotationsOperationInput
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumerOptions")]
        public global::Dataloop.PickStartInputAnyMaxBytesOrMaxMessages? ConsumerOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.BenchmarkIngestionStrategyTypeJsonConverter))]
        public global::Dataloop.BenchmarkIngestionStrategyType? Strategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public double? Concurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generatedDatasetConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.GeneratedDatasetConfig GeneratedDatasetConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumerAmount")]
        public double? ConsumerAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generatedDatasetType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.GeneratedDatasetTypesJsonConverter))]
        public global::Dataloop.GeneratedDatasetTypes? GeneratedDatasetType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddAnnotationsOperationInput" /> class.
        /// </summary>
        /// <param name="generatedDatasetConfig"></param>
        /// <param name="datasetId"></param>
        /// <param name="consumerOptions">
        /// From T, pick a set of properties whose keys are in the union K
        /// </param>
        /// <param name="strategy"></param>
        /// <param name="concurrency"></param>
        /// <param name="consumerAmount"></param>
        /// <param name="generatedDatasetType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddAnnotationsOperationInput(
            global::Dataloop.GeneratedDatasetConfig generatedDatasetConfig,
            string datasetId,
            global::Dataloop.PickStartInputAnyMaxBytesOrMaxMessages? consumerOptions,
            global::Dataloop.BenchmarkIngestionStrategyType? strategy,
            double? concurrency,
            double? consumerAmount,
            global::Dataloop.GeneratedDatasetTypes? generatedDatasetType)
        {
            this.ConsumerOptions = consumerOptions;
            this.Strategy = strategy;
            this.Concurrency = concurrency;
            this.GeneratedDatasetConfig = generatedDatasetConfig ?? throw new global::System.ArgumentNullException(nameof(generatedDatasetConfig));
            this.ConsumerAmount = consumerAmount;
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.GeneratedDatasetType = generatedDatasetType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddAnnotationsOperationInput" /> class.
        /// </summary>
        public AddAnnotationsOperationInput()
        {
        }
    }
}