
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetTaskRefsBenchmarkInput
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
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.SetTaskRefsBenchmarkInputOperationJsonConverter))]
        public global::Dataloop.SetTaskRefsBenchmarkInputOperation? Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsQuery")]
        public global::Dataloop.Dictionary? ItemsQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskIds")]
        public global::System.Collections.Generic.IList<string>? TaskIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignmentIds")]
        public global::System.Collections.Generic.IList<string>? AssignmentIds { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateItemsBatchSize")]
        public double? UpdateItemsBatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTaskRefsBenchmarkInput" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="operation"></param>
        /// <param name="itemsQuery"></param>
        /// <param name="taskIds"></param>
        /// <param name="assignmentIds"></param>
        /// <param name="concurrency"></param>
        /// <param name="itemsBatchSize"></param>
        /// <param name="updateItemsBatchSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetTaskRefsBenchmarkInput(
            string datasetId,
            global::Dataloop.SetTaskRefsBenchmarkInputOperation? operation,
            global::Dataloop.Dictionary? itemsQuery,
            global::System.Collections.Generic.IList<string>? taskIds,
            global::System.Collections.Generic.IList<string>? assignmentIds,
            double? concurrency,
            double? itemsBatchSize,
            double? updateItemsBatchSize)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.Operation = operation;
            this.ItemsQuery = itemsQuery;
            this.TaskIds = taskIds;
            this.AssignmentIds = assignmentIds;
            this.Concurrency = concurrency;
            this.ItemsBatchSize = itemsBatchSize;
            this.UpdateItemsBatchSize = updateItemsBatchSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTaskRefsBenchmarkInput" /> class.
        /// </summary>
        public SetTaskRefsBenchmarkInput()
        {
        }
    }
}