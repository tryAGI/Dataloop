
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IPipelineStatistics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineExecutionCounters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.IPipelineExecutionCount> PipelineExecutionCounters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeExecutionsCounters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.INodeExecutionCount> NodeExecutionsCounters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineExecutionStatistics")]
        public global::Dataloop.IExecutionStatistics? PipelineExecutionStatistics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeExecutionStatistics")]
        public global::System.Collections.Generic.IList<global::Dataloop.INodeExecutionStatistics>? NodeExecutionStatistics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IPipelineStatistics" /> class.
        /// </summary>
        /// <param name="pipelineExecutionCounters"></param>
        /// <param name="nodeExecutionsCounters"></param>
        /// <param name="pipelineExecutionStatistics"></param>
        /// <param name="nodeExecutionStatistics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IPipelineStatistics(
            global::System.Collections.Generic.IList<global::Dataloop.IPipelineExecutionCount> pipelineExecutionCounters,
            global::System.Collections.Generic.IList<global::Dataloop.INodeExecutionCount> nodeExecutionsCounters,
            global::Dataloop.IExecutionStatistics? pipelineExecutionStatistics,
            global::System.Collections.Generic.IList<global::Dataloop.INodeExecutionStatistics>? nodeExecutionStatistics)
        {
            this.PipelineExecutionCounters = pipelineExecutionCounters ?? throw new global::System.ArgumentNullException(nameof(pipelineExecutionCounters));
            this.NodeExecutionsCounters = nodeExecutionsCounters ?? throw new global::System.ArgumentNullException(nameof(nodeExecutionsCounters));
            this.PipelineExecutionStatistics = pipelineExecutionStatistics;
            this.NodeExecutionStatistics = nodeExecutionStatistics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPipelineStatistics" /> class.
        /// </summary>
        public IPipelineStatistics()
        {
        }
    }
}