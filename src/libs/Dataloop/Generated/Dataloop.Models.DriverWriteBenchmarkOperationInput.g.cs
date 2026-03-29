
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DriverWriteBenchmarkOperationInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarioDetails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DriverWriteBenchmarkOperationInputScenarioDetailsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DriverWriteBenchmarkOperationInputScenarioDetails ScenarioDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsNumber")]
        public double? ItemsNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public double? Concurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("producersAmount")]
        public double? ProducersAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waitUntilCompletion")]
        public bool? WaitUntilCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetWithItemsToStreamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetWithItemsToStreamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DriverId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DriverWriteBenchmarkOperationInput" /> class.
        /// </summary>
        /// <param name="scenarioDetails"></param>
        /// <param name="datasetWithItemsToStreamId"></param>
        /// <param name="driverId"></param>
        /// <param name="projectId"></param>
        /// <param name="itemsNumber"></param>
        /// <param name="concurrency"></param>
        /// <param name="producersAmount"></param>
        /// <param name="waitUntilCompletion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DriverWriteBenchmarkOperationInput(
            global::Dataloop.DriverWriteBenchmarkOperationInputScenarioDetails scenarioDetails,
            string datasetWithItemsToStreamId,
            string driverId,
            string? projectId,
            double? itemsNumber,
            double? concurrency,
            double? producersAmount,
            bool? waitUntilCompletion)
        {
            this.ScenarioDetails = scenarioDetails;
            this.ProjectId = projectId;
            this.ItemsNumber = itemsNumber;
            this.Concurrency = concurrency;
            this.ProducersAmount = producersAmount;
            this.WaitUntilCompletion = waitUntilCompletion;
            this.DatasetWithItemsToStreamId = datasetWithItemsToStreamId ?? throw new global::System.ArgumentNullException(nameof(datasetWithItemsToStreamId));
            this.DriverId = driverId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriverWriteBenchmarkOperationInput" /> class.
        /// </summary>
        public DriverWriteBenchmarkOperationInput()
        {
        }
    }
}