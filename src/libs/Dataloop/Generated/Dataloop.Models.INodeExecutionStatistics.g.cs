
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class INodeExecutionStatistics
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
        [global::System.Text.Json.Serialization.JsonPropertyName("executionStatistics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IExecutionStatistics ExecutionStatistics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="INodeExecutionStatistics" /> class.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="executionStatistics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public INodeExecutionStatistics(
            string nodeId,
            global::Dataloop.IExecutionStatistics executionStatistics)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.ExecutionStatistics = executionStatistics ?? throw new global::System.ArgumentNullException(nameof(executionStatistics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="INodeExecutionStatistics" /> class.
        /// </summary>
        public INodeExecutionStatistics()
        {
        }
    }
}