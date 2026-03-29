
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ItemRefsUpdateBulkRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.TaskItemStatus Action { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineId")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ItemIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asynced")]
        public bool? Asynced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRefsUpdateBulkRequest" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="operation"></param>
        /// <param name="itemIds"></param>
        /// <param name="pipelineId"></param>
        /// <param name="nodeId"></param>
        /// <param name="asynced"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemRefsUpdateBulkRequest(
            global::Dataloop.TaskItemStatus action,
            global::Dataloop.ItemRefOperation operation,
            global::System.Collections.Generic.IList<string> itemIds,
            string? pipelineId,
            string? nodeId,
            bool? asynced)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Operation = operation;
            this.PipelineId = pipelineId;
            this.NodeId = nodeId;
            this.ItemIds = itemIds ?? throw new global::System.ArgumentNullException(nameof(itemIds));
            this.Asynced = asynced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRefsUpdateBulkRequest" /> class.
        /// </summary>
        public ItemRefsUpdateBulkRequest()
        {
        }
    }
}