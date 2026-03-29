
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetTaskRefsStatusBenchmarkInput
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
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsQuery")]
        public global::Dataloop.Dictionary? ItemsQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.TaskItemStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousStatus")]
        public string? PreviousStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ItemRefOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ItemRefOperation Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public double? Concurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsBatchSize")]
        public double? ItemsBatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTaskRefsStatusBenchmarkInput" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="status"></param>
        /// <param name="operation"></param>
        /// <param name="itemsQuery"></param>
        /// <param name="previousStatus"></param>
        /// <param name="concurrency"></param>
        /// <param name="itemsBatchSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetTaskRefsStatusBenchmarkInput(
            string datasetId,
            global::Dataloop.TaskItemStatus status,
            global::Dataloop.ItemRefOperation operation,
            global::Dataloop.Dictionary? itemsQuery,
            string? previousStatus,
            double? concurrency,
            double? itemsBatchSize)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.ItemsQuery = itemsQuery;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.PreviousStatus = previousStatus;
            this.Operation = operation;
            this.Concurrency = concurrency;
            this.ItemsBatchSize = itemsBatchSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTaskRefsStatusBenchmarkInput" /> class.
        /// </summary>
        public SetTaskRefsStatusBenchmarkInput()
        {
        }
    }
}