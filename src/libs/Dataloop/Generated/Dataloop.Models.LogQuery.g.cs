
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceId")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follow")]
        public bool? Follow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public double? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint")]
        public string? Checkpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.LogsListDirectionJsonConverter))]
        public global::Dataloop.LogsListDirection? Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public global::System.DateTime? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionName")]
        public string? FunctionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicaId")]
        public string? ReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ServiceLogLevelJsonConverter))]
        public global::Dataloop.ServiceLogLevel? LogLevel { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public bool? System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? ProjectId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("includeServiceLevel")]
        public bool? IncludeServiceLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogQuery" /> class.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="follow"></param>
        /// <param name="size"></param>
        /// <param name="checkpoint"></param>
        /// <param name="direction"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="executionId"></param>
        /// <param name="functionName"></param>
        /// <param name="replicaId"></param>
        /// <param name="text"></param>
        /// <param name="logLevel"></param>
        /// <param name="pipelineId"></param>
        /// <param name="nodeId"></param>
        /// <param name="pipelineExecutionId"></param>
        /// <param name="system"></param>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="modelOperation"></param>
        /// <param name="includeServiceLevel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogQuery(
            string? serviceId,
            bool? follow,
            double? size,
            string? checkpoint,
            global::Dataloop.LogsListDirection? direction,
            global::System.DateTime? start,
            global::System.DateTime? end,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? executionId,
            string? functionName,
            string? replicaId,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? text,
            global::Dataloop.ServiceLogLevel? logLevel,
            string? pipelineId,
            string? nodeId,
            string? pipelineExecutionId,
            bool? system,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? projectId,
            string? modelId,
            string? modelOperation,
            bool? includeServiceLevel)
        {
            this.ServiceId = serviceId;
            this.Follow = follow;
            this.Size = size;
            this.Checkpoint = checkpoint;
            this.Direction = direction;
            this.Start = start;
            this.End = end;
            this.ExecutionId = executionId;
            this.FunctionName = functionName;
            this.ReplicaId = replicaId;
            this.Text = text;
            this.LogLevel = logLevel;
            this.PipelineId = pipelineId;
            this.NodeId = nodeId;
            this.PipelineExecutionId = pipelineExecutionId;
            this.System = system;
            this.ProjectId = projectId;
            this.ModelId = modelId;
            this.ModelOperation = modelOperation;
            this.IncludeServiceLevel = includeServiceLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogQuery" /> class.
        /// </summary>
        public LogQuery()
        {
        }
    }
}