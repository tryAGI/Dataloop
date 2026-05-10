
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionPipeline
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
        public double? VersionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionPipeline" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="executionId"></param>
        /// <param name="versionNumber"></param>
        /// <param name="archived"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionPipeline(
            string id,
            string nodeId,
            string executionId,
            double? versionNumber,
            bool? archived)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.VersionNumber = versionNumber;
            this.Archived = archived;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionPipeline" /> class.
        /// </summary>
        public ExecutionPipeline()
        {
        }
    }
}