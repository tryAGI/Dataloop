
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceLogEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicaId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionId")]
        public string? ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionName")]
        public string? FunctionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ServiceLogLevelJsonConverter))]
        public global::Dataloop.ServiceLogLevel? Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelOperation")]
        public string? ModelOperation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceId")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? ProjectId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineExecutionId")]
        public string? PipelineExecutionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLogEntry" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <param name="replicaId"></param>
        /// <param name="executionId"></param>
        /// <param name="functionName"></param>
        /// <param name="level"></param>
        /// <param name="modelId"></param>
        /// <param name="modelOperation"></param>
        /// <param name="serviceId"></param>
        /// <param name="projectId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="nodeId"></param>
        /// <param name="pipelineExecutionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceLogEntry(
            string message,
            object timestamp,
            string replicaId,
            string? executionId,
            string? functionName,
            global::Dataloop.ServiceLogLevel? level,
            string? modelId,
            string? modelOperation,
            string? serviceId,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? projectId,
            string? pipelineId,
            string? nodeId,
            string? pipelineExecutionId)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.ReplicaId = replicaId ?? throw new global::System.ArgumentNullException(nameof(replicaId));
            this.ExecutionId = executionId;
            this.FunctionName = functionName;
            this.Level = level;
            this.ModelId = modelId;
            this.ModelOperation = modelOperation;
            this.ServiceId = serviceId;
            this.ProjectId = projectId;
            this.PipelineId = pipelineId;
            this.NodeId = nodeId;
            this.PipelineExecutionId = pipelineExecutionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLogEntry" /> class.
        /// </summary>
        public ServiceLogEntry()
        {
        }
    }
}