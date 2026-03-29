
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskMetadataSystem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructionDocument")]
        public global::Dataloop.PartialTaskInstructionsDocumentDetails? InstructionDocument { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasDefaultAssignment")]
        public bool? HasDefaultAssignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        public bool? Locked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforceDueDate")]
        public bool? EnforceDueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markForDeletion")]
        public bool? MarkForDeletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive")]
        public bool? Archive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskError")]
        public string? TaskError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workloadDistribution")]
        public global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? WorkloadDistribution { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring")]
        public bool? Scoring { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webmInstalled")]
        public bool? WebmInstalled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableWebm")]
        public bool? DisableWebm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensusAssignees")]
        public double? ConsensusAssignees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensusPercentage")]
        public double? ConsensusPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensusTaskType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.QualityTaskTypesJsonConverter))]
        public global::Dataloop.QualityTaskTypes? ConsensusTaskType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relatedTasks")]
        public global::System.Collections.Generic.IList<string>? RelatedTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<string>? Groups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedAssignees")]
        public global::System.Collections.Generic.IList<string>? AllowedAssignees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxBatchWorkload")]
        public double? MaxBatchWorkload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchSize")]
        public double? BatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextIndex")]
        public double? NextIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskMetadataSystem" /> class.
        /// </summary>
        /// <param name="instructionDocument"></param>
        /// <param name="hasDefaultAssignment"></param>
        /// <param name="locked"></param>
        /// <param name="enforceDueDate"></param>
        /// <param name="markForDeletion"></param>
        /// <param name="archive"></param>
        /// <param name="taskError"></param>
        /// <param name="workloadDistribution"></param>
        /// <param name="nodeId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="scoring"></param>
        /// <param name="webmInstalled"></param>
        /// <param name="disableWebm"></param>
        /// <param name="consensusAssignees"></param>
        /// <param name="consensusPercentage"></param>
        /// <param name="consensusTaskType"></param>
        /// <param name="relatedTasks"></param>
        /// <param name="groups"></param>
        /// <param name="allowedAssignees"></param>
        /// <param name="maxBatchWorkload"></param>
        /// <param name="batchSize"></param>
        /// <param name="nextIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskMetadataSystem(
            global::Dataloop.PartialTaskInstructionsDocumentDetails? instructionDocument,
            bool? hasDefaultAssignment,
            bool? locked,
            bool? enforceDueDate,
            bool? markForDeletion,
            bool? archive,
            string? taskError,
            global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? workloadDistribution,
            string? nodeId,
            string? pipelineId,
            bool? scoring,
            bool? webmInstalled,
            bool? disableWebm,
            double? consensusAssignees,
            double? consensusPercentage,
            global::Dataloop.QualityTaskTypes? consensusTaskType,
            global::System.Collections.Generic.IList<string>? relatedTasks,
            global::System.Collections.Generic.IList<string>? groups,
            global::System.Collections.Generic.IList<string>? allowedAssignees,
            double? maxBatchWorkload,
            double? batchSize,
            double? nextIndex)
        {
            this.InstructionDocument = instructionDocument;
            this.HasDefaultAssignment = hasDefaultAssignment;
            this.Locked = locked;
            this.EnforceDueDate = enforceDueDate;
            this.MarkForDeletion = markForDeletion;
            this.Archive = archive;
            this.TaskError = taskError;
            this.WorkloadDistribution = workloadDistribution;
            this.NodeId = nodeId;
            this.PipelineId = pipelineId;
            this.Scoring = scoring;
            this.WebmInstalled = webmInstalled;
            this.DisableWebm = disableWebm;
            this.ConsensusAssignees = consensusAssignees;
            this.ConsensusPercentage = consensusPercentage;
            this.ConsensusTaskType = consensusTaskType;
            this.RelatedTasks = relatedTasks;
            this.Groups = groups;
            this.AllowedAssignees = allowedAssignees;
            this.MaxBatchWorkload = maxBatchWorkload;
            this.BatchSize = batchSize;
            this.NextIndex = nextIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskMetadataSystem" /> class.
        /// </summary>
        public TaskMetadataSystem()
        {
        }
    }
}