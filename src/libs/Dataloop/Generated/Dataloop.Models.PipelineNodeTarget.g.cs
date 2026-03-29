
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelineNodeTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("portId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PortId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineNodeTarget" /> class.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="portId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineNodeTarget(
            string nodeId,
            string portId)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.PortId = portId ?? throw new global::System.ArgumentNullException(nameof(portId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineNodeTarget" /> class.
        /// </summary>
        public PipelineNodeTarget()
        {
        }
    }
}