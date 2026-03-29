
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ItemRefsUpdateRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRefsUpdateRequest" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="operation"></param>
        /// <param name="pipelineId"></param>
        /// <param name="nodeId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemRefsUpdateRequest(
            global::Dataloop.TaskItemStatus action,
            global::Dataloop.ItemRefOperation operation,
            string? pipelineId,
            string? nodeId)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Operation = operation;
            this.PipelineId = pipelineId;
            this.NodeId = nodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRefsUpdateRequest" /> class.
        /// </summary>
        public ItemRefsUpdateRequest()
        {
        }
    }
}