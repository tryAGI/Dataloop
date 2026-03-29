
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DriverReadBenchmarkOperationInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarioDetails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DriverReadBenchmarkOperationInputScenarioDetailsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails ScenarioDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addingItemsInParallel")]
        public double? AddingItemsInParallel { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("consumersAmount")]
        public double? ConsumersAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waitUntilCompletion")]
        public bool? WaitUntilCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

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
        /// Initializes a new instance of the <see cref="DriverReadBenchmarkOperationInput" /> class.
        /// </summary>
        /// <param name="scenarioDetails"></param>
        /// <param name="projectId"></param>
        /// <param name="datasetWithItemsToStreamId"></param>
        /// <param name="driverId"></param>
        /// <param name="addingItemsInParallel"></param>
        /// <param name="itemsNumber"></param>
        /// <param name="concurrency"></param>
        /// <param name="consumersAmount"></param>
        /// <param name="waitUntilCompletion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DriverReadBenchmarkOperationInput(
            global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails scenarioDetails,
            string projectId,
            string datasetWithItemsToStreamId,
            string driverId,
            double? addingItemsInParallel,
            double? itemsNumber,
            double? concurrency,
            double? consumersAmount,
            bool? waitUntilCompletion)
        {
            this.ScenarioDetails = scenarioDetails;
            this.AddingItemsInParallel = addingItemsInParallel;
            this.ItemsNumber = itemsNumber;
            this.Concurrency = concurrency;
            this.ConsumersAmount = consumersAmount;
            this.WaitUntilCompletion = waitUntilCompletion;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DatasetWithItemsToStreamId = datasetWithItemsToStreamId ?? throw new global::System.ArgumentNullException(nameof(datasetWithItemsToStreamId));
            this.DriverId = driverId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriverReadBenchmarkOperationInput" /> class.
        /// </summary>
        public DriverReadBenchmarkOperationInput()
        {
        }
    }
}