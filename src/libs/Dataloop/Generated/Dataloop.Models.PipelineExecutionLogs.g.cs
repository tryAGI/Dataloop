
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelineExecutionLogs
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
        [global::System.Text.Json.Serialization.JsonPropertyName("executions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.ExecutionLogs> Executions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineExecutionLogs" /> class.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="executions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineExecutionLogs(
            string nodeId,
            global::System.Collections.Generic.IList<global::Dataloop.ExecutionLogs> executions)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Executions = executions ?? throw new global::System.ArgumentNullException(nameof(executions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineExecutionLogs" /> class.
        /// </summary>
        public PipelineExecutionLogs()
        {
        }
    }
}