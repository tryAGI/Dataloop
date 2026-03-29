
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIAssignment
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
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Annotator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AssignmentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AssignmentStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("taskType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("inRedistributeProcess")]
        public global::System.DateTime? InRedistributeProcess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeItemsProcess")]
        public global::Dataloop.APIAssignmentRemoveItemsProcess? RemoveItemsProcess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redistributeProcess")]
        public global::Dataloop.APIAssignmentRedistributeProcess? RedistributeProcess { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIAssignment" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="annotator"></param>
        /// <param name="status"></param>
        /// <param name="projectId"></param>
        /// <param name="metadata"></param>
        /// <param name="totalItems"></param>
        /// <param name="itemStatus"></param>
        /// <param name="taskType"></param>
        /// <param name="progress"></param>
        /// <param name="forReview"></param>
        /// <param name="issues"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="inRedistributeProcess"></param>
        /// <param name="removeItemsProcess"></param>
        /// <param name="redistributeProcess"></param>
        /// <param name="error"></param>
        /// <param name="priority"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIAssignment(
            string id,
            string url,
            string name,
            string annotator,
            global::Dataloop.AssignmentStatus status,
            string projectId,
            global::Dataloop.APIMetadata metadata,
            double totalItems,
            global::Dataloop.ItemStatus itemStatus,
            string taskType,
            double progress,
            double forReview,
            double issues,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            global::System.DateTime? inRedistributeProcess,
            global::Dataloop.APIAssignmentRemoveItemsProcess? removeItemsProcess,
            global::Dataloop.APIAssignmentRedistributeProcess? redistributeProcess,
            string? error,
            double? priority)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Annotator = annotator ?? throw new global::System.ArgumentNullException(nameof(annotator));
            this.Status = status;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.TotalItems = totalItems;
            this.ItemStatus = itemStatus ?? throw new global::System.ArgumentNullException(nameof(itemStatus));
            this.TaskType = taskType ?? throw new global::System.ArgumentNullException(nameof(taskType));
            this.Progress = progress;
            this.ForReview = forReview;
            this.Issues = issues;
            this.InRedistributeProcess = inRedistributeProcess;
            this.RemoveItemsProcess = removeItemsProcess;
            this.RedistributeProcess = redistributeProcess;
            this.Error = error;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIAssignment" /> class.
        /// </summary>
        public APIAssignment()
        {
        }
    }
}