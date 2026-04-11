
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
        public string? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Dataloop.ItemStatusEventStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineId")]
        public string? PipelineId { get; set; }

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
            string? action,
            global::Dataloop.ItemStatusEventStatus? status,
            string? nodeId,
            string? pipelineId)
        {
            this.Action = action;
            this.Status = status;
            this.NodeId = nodeId;
            this.PipelineId = pipelineId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemStatusEvent" /> class.
        /// </summary>
        public ItemStatusEvent()
        {
        }
    }
}