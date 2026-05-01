
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IPipelineState
    {
        /// <summary>
        /// A class representation of the BSON ObjectId type.
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
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EPipelineStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.EPipelineStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Executions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.IPipelineNodeState> Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countInProgress")]
        public double? CountInProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPipelineFailed")]
        public bool? IsPipelineFailed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAttempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

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
        public object? TaskNodeItemCount { get; set; }

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
        /// Initializes a new instance of the <see cref="IPipelineState" /> class.
        /// </summary>
        /// <param name="pipelineId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="status"></param>
        /// <param name="executions"></param>
        /// <param name="nodes"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="pipelineVersionNumber"></param>
        /// <param name="projectId"></param>
        /// <param name="creator"></param>
        /// <param name="countInProgress"></param>
        /// <param name="isPipelineFailed"></param>
        /// <param name="duration"></param>
        /// <param name="transitionErrors"></param>
        /// <param name="mergeCount"></param>
        /// <param name="taskNodeItemCount"></param>
        /// <param name="testMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IPipelineState(
            string pipelineId,
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Dataloop.EPipelineStatus status,
            global::Dataloop.Dictionary executions,
            global::System.Collections.Generic.IList<global::Dataloop.IPipelineNodeState> nodes,
            double maxAttempts,
            double? pipelineVersionNumber,
            string? projectId,
            string? creator,
            double? countInProgress,
            bool? isPipelineFailed,
            double? duration,
            global::System.Collections.Generic.IList<global::Dataloop.INodeTransitionError>? transitionErrors,
            global::System.Collections.Generic.Dictionary<string, double>? mergeCount,
            object? taskNodeItemCount,
            bool? testMode)
        {
            this.PipelineId = pipelineId ?? throw new global::System.ArgumentNullException(nameof(pipelineId));
            this.PipelineVersionNumber = pipelineVersionNumber;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId;
            this.Creator = creator;
            this.Status = status;
            this.Executions = executions ?? throw new global::System.ArgumentNullException(nameof(executions));
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.CountInProgress = countInProgress;
            this.IsPipelineFailed = isPipelineFailed;
            this.MaxAttempts = maxAttempts;
            this.Duration = duration;
            this.TransitionErrors = transitionErrors;
            this.MergeCount = mergeCount;
            this.TaskNodeItemCount = taskNodeItemCount;
            this.TestMode = testMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPipelineState" /> class.
        /// </summary>
        public IPipelineState()
        {
        }
    }
}