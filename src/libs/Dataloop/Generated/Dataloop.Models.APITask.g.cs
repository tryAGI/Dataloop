
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APITask
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
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DueDate { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec> Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasParent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasParent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignmentIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AssignmentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.TaskStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.TaskStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalItems")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemStatus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ItemStatus ItemStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forReview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ForReview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableActions")]
        public global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? AvailableActions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emptyInactiveAssignments")]
        public double? EmptyInactiveAssignments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::Dataloop.Description? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasDueDate")]
        public bool? HasDueDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APITask" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="name"></param>
        /// <param name="taskOwner"></param>
        /// <param name="dueDate"></param>
        /// <param name="datasetId"></param>
        /// <param name="recipeId"></param>
        /// <param name="projectId"></param>
        /// <param name="spec"></param>
        /// <param name="hasParent"></param>
        /// <param name="query"></param>
        /// <param name="assignmentIds"></param>
        /// <param name="status"></param>
        /// <param name="metadata"></param>
        /// <param name="totalItems"></param>
        /// <param name="itemStatus"></param>
        /// <param name="progress"></param>
        /// <param name="forReview"></param>
        /// <param name="issues"></param>
        /// <param name="updatedBy"></param>
        /// <param name="availableActions"></param>
        /// <param name="error"></param>
        /// <param name="priority"></param>
        /// <param name="emptyInactiveAssignments"></param>
        /// <param name="description"></param>
        /// <param name="hasDueDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APITask(
            string id,
            string url,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string creator,
            string name,
            string taskOwner,
            double dueDate,
            string datasetId,
            string recipeId,
            string projectId,
            global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec> spec,
            bool hasParent,
            string query,
            global::System.Collections.Generic.IList<string> assignmentIds,
            global::Dataloop.TaskStatus status,
            global::Dataloop.APIMetadata metadata,
            double totalItems,
            global::Dataloop.ItemStatus itemStatus,
            double progress,
            double forReview,
            double issues,
            string? updatedBy,
            global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? availableActions,
            string? error,
            double? priority,
            double? emptyInactiveAssignments,
            global::Dataloop.Description? description,
            bool? hasDueDate)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TaskOwner = taskOwner ?? throw new global::System.ArgumentNullException(nameof(taskOwner));
            this.DueDate = dueDate;
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.RecipeId = recipeId ?? throw new global::System.ArgumentNullException(nameof(recipeId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Spec = spec;
            this.HasParent = hasParent;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.AssignmentIds = assignmentIds ?? throw new global::System.ArgumentNullException(nameof(assignmentIds));
            this.Status = status;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.TotalItems = totalItems;
            this.ItemStatus = itemStatus ?? throw new global::System.ArgumentNullException(nameof(itemStatus));
            this.Progress = progress;
            this.ForReview = forReview;
            this.Issues = issues;
            this.AvailableActions = availableActions;
            this.Error = error;
            this.Priority = priority;
            this.EmptyInactiveAssignments = emptyInactiveAssignments;
            this.Description = description;
            this.HasDueDate = hasDueDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APITask" /> class.
        /// </summary>
        public APITask()
        {
        }
    }
}