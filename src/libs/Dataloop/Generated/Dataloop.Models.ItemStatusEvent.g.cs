
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ItemStatusEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ItemStatusEventStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PipelineId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemStatusEvent" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="status"></param>
        /// <param name="nodeId"></param>
        /// <param name="pipelineId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemStatusEvent(
            string action,
            global::Dataloop.ItemStatusEventStatus status,
            string nodeId,
            string pipelineId)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.PipelineId = pipelineId ?? throw new global::System.ArgumentNullException(nameof(pipelineId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemStatusEvent" /> class.
        /// </summary>
        public ItemStatusEvent()
        {
        }
    }
}