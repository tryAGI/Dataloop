
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIPipelineState
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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineVersionNumber")]
        public double? PipelineVersionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Dataloop.PartialExecution>> Executions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.IPipelineNodeState> Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EPipelineStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.EPipelineStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAttempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transitionErrors")]
        public global::System.Collections.Generic.IList<global::Dataloop.INodeTransitionError>? TransitionErrors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mergeCount")]
        public global::System.Collections.Generic.Dictionary<string, double>? MergeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskNodeItemCount")]
        public global::System.Collections.Generic.Dictionary<string, double>? TaskNodeItemCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testMode")]
        public bool? TestMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPipelineState" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="pipelineId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="executions"></param>
        /// <param name="nodes"></param>
        /// <param name="status"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="pipelineVersionNumber"></param>
        /// <param name="projectId"></param>
        /// <param name="creator"></param>
        /// <param name="transitionErrors"></param>
        /// <param name="mergeCount"></param>
        /// <param name="taskNodeItemCount"></param>
        /// <param name="testMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIPipelineState(
            string id,
            string url,
            string pipelineId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Dataloop.PartialExecution>> executions,
            global::System.Collections.Generic.IList<global::Dataloop.IPipelineNodeState> nodes,
            global::Dataloop.EPipelineStatus status,
            double maxAttempts,
            double? pipelineVersionNumber,
            string? projectId,
            string? creator,
            global::System.Collections.Generic.IList<global::Dataloop.INodeTransitionError>? transitionErrors,
            global::System.Collections.Generic.Dictionary<string, double>? mergeCount,
            global::System.Collections.Generic.Dictionary<string, double>? taskNodeItemCount,
            bool? testMode)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PipelineId = pipelineId ?? throw new global::System.ArgumentNullException(nameof(pipelineId));
            this.PipelineVersionNumber = pipelineVersionNumber;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId;
            this.Creator = creator;
            this.Executions = executions ?? throw new global::System.ArgumentNullException(nameof(executions));
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Status = status;
            this.MaxAttempts = maxAttempts;
            this.TransitionErrors = transitionErrors;
            this.MergeCount = mergeCount;
            this.TaskNodeItemCount = taskNodeItemCount;
            this.TestMode = testMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPipelineState" /> class.
        /// </summary>
        public APIPipelineState()
        {
        }
    }
}