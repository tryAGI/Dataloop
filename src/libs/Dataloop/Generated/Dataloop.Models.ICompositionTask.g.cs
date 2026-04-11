
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICompositionTask
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskOwner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecipeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dueDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ICompositionTaskState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload")]
        public global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? Workload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableActions")]
        public global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? AvailableActions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.TaskTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.TaskType TaskType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchSize")]
        public double? BatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxBatchWorkload")]
        public double? MaxBatchWorkload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relatedTasks")]
        public global::System.Collections.Generic.IList<double>? RelatedTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public double? Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensusTaskType")]
        public string? ConsensusTaskType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("disableWebm")]
        public bool? DisableWebm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<string>? Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionTask" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="taskOwner"></param>
        /// <param name="recipeId"></param>
        /// <param name="name"></param>
        /// <param name="dueDate"></param>
        /// <param name="state"></param>
        /// <param name="metadata"></param>
        /// <param name="nodeId"></param>
        /// <param name="taskType"></param>
        /// <param name="workload"></param>
        /// <param name="availableActions"></param>
        /// <param name="batchSize"></param>
        /// <param name="maxBatchWorkload"></param>
        /// <param name="relatedTasks"></param>
        /// <param name="identifier"></param>
        /// <param name="consensusTaskType"></param>
        /// <param name="consensusAssignees"></param>
        /// <param name="consensusPercentage"></param>
        /// <param name="disableWebm"></param>
        /// <param name="priority"></param>
        /// <param name="groups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICompositionTask(
            string datasetId,
            string taskOwner,
            string recipeId,
            string name,
            double dueDate,
            global::Dataloop.ICompositionTaskState state,
            global::Dataloop.Dictionary metadata,
            string nodeId,
            global::Dataloop.TaskType taskType,
            global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? workload,
            global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? availableActions,
            double? batchSize,
            double? maxBatchWorkload,
            global::System.Collections.Generic.IList<double>? relatedTasks,
            double? identifier,
            string? consensusTaskType,
            double? consensusAssignees,
            double? consensusPercentage,
            bool? disableWebm,
            double? priority,
            global::System.Collections.Generic.IList<string>? groups)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.TaskOwner = taskOwner ?? throw new global::System.ArgumentNullException(nameof(taskOwner));
            this.RecipeId = recipeId ?? throw new global::System.ArgumentNullException(nameof(recipeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DueDate = dueDate;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Workload = workload;
            this.AvailableActions = availableActions;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.TaskType = taskType;
            this.BatchSize = batchSize;
            this.MaxBatchWorkload = maxBatchWorkload;
            this.RelatedTasks = relatedTasks;
            this.Identifier = identifier;
            this.ConsensusTaskType = consensusTaskType;
            this.ConsensusAssignees = consensusAssignees;
            this.ConsensusPercentage = consensusPercentage;
            this.DisableWebm = disableWebm;
            this.Priority = priority;
            this.Groups = groups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionTask" /> class.
        /// </summary>
        public ICompositionTask()
        {
        }
    }
}