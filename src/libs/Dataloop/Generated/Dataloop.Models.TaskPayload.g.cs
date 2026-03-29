
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskPayload
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
        [global::System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecipeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskOwner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dueDate")]
        public double? DueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignmentIds")]
        public global::System.Collections.Generic.IList<string>? AssignmentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec> Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload")]
        public global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? Workload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage")]
        public bool? Percentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asynced")]
        public bool? Asynced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emptyTask")]
        public bool? EmptyTask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkIfExist")]
        public global::Dataloop.TaskPayloadCheckIfExist? CheckIfExist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableActions")]
        public global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? AvailableActions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableWebm")]
        public bool? DisableWebm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.TaskMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::Dataloop.PickDescriptionContent? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPayload" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="recipeId"></param>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="taskOwner"></param>
        /// <param name="query"></param>
        /// <param name="spec"></param>
        /// <param name="dueDate"></param>
        /// <param name="status"></param>
        /// <param name="assignmentIds"></param>
        /// <param name="workload"></param>
        /// <param name="limit"></param>
        /// <param name="percentage"></param>
        /// <param name="asynced"></param>
        /// <param name="emptyTask"></param>
        /// <param name="checkIfExist"></param>
        /// <param name="availableActions"></param>
        /// <param name="disableWebm"></param>
        /// <param name="metadata"></param>
        /// <param name="priority"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskPayload(
            string datasetId,
            string recipeId,
            string projectId,
            string name,
            string taskOwner,
            string query,
            global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec> spec,
            double? dueDate,
            string? status,
            global::System.Collections.Generic.IList<string>? assignmentIds,
            global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? workload,
            double? limit,
            bool? percentage,
            bool? asynced,
            bool? emptyTask,
            global::Dataloop.TaskPayloadCheckIfExist? checkIfExist,
            global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? availableActions,
            bool? disableWebm,
            global::Dataloop.TaskMetadata? metadata,
            double? priority,
            global::Dataloop.PickDescriptionContent? description)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.RecipeId = recipeId ?? throw new global::System.ArgumentNullException(nameof(recipeId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TaskOwner = taskOwner ?? throw new global::System.ArgumentNullException(nameof(taskOwner));
            this.DueDate = dueDate;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Status = status;
            this.AssignmentIds = assignmentIds;
            this.Spec = spec;
            this.Workload = workload;
            this.Limit = limit;
            this.Percentage = percentage;
            this.Asynced = asynced;
            this.EmptyTask = emptyTask;
            this.CheckIfExist = checkIfExist;
            this.AvailableActions = availableActions;
            this.DisableWebm = disableWebm;
            this.Metadata = metadata;
            this.Priority = priority;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPayload" /> class.
        /// </summary>
        public TaskPayload()
        {
        }
    }
}