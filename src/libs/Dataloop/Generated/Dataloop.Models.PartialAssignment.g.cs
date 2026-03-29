
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialAssignment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator")]
        public string? Annotator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.AssignmentMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalItems")]
        public double? TotalItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemStatus")]
        public global::Dataloop.ItemStatus? ItemStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.TaskTypeJsonConverter))]
        public global::Dataloop.TaskType? TaskType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forReview")]
        public double? ForReview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public double? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inRedistributeProcess")]
        public global::System.DateTime? InRedistributeProcess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redistributeProcess")]
        public global::Dataloop.PartialAssignmentRedistributeProcess? RedistributeProcess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeItemsProcess")]
        public global::Dataloop.PartialAssignmentRemoveItemsProcess? RemoveItemsProcess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authz")]
        public global::Dataloop.AuthZBlockAssignmentContext? Authz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAssignment" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="annotator"></param>
        /// <param name="projectId"></param>
        /// <param name="metadata"></param>
        /// <param name="totalItems"></param>
        /// <param name="itemStatus"></param>
        /// <param name="taskType"></param>
        /// <param name="forReview"></param>
        /// <param name="issues"></param>
        /// <param name="inRedistributeProcess"></param>
        /// <param name="redistributeProcess"></param>
        /// <param name="removeItemsProcess"></param>
        /// <param name="error"></param>
        /// <param name="authz"></param>
        /// <param name="priority"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialAssignment(
            string? id,
            string? name,
            string? annotator,
            string? projectId,
            global::Dataloop.AssignmentMetadata? metadata,
            double? totalItems,
            global::Dataloop.ItemStatus? itemStatus,
            global::Dataloop.TaskType? taskType,
            double? forReview,
            double? issues,
            global::System.DateTime? inRedistributeProcess,
            global::Dataloop.PartialAssignmentRedistributeProcess? redistributeProcess,
            global::Dataloop.PartialAssignmentRemoveItemsProcess? removeItemsProcess,
            string? error,
            global::Dataloop.AuthZBlockAssignmentContext? authz,
            double? priority,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? updatedBy)
        {
            this.Id = id;
            this.Name = name;
            this.Annotator = annotator;
            this.ProjectId = projectId;
            this.Metadata = metadata;
            this.TotalItems = totalItems;
            this.ItemStatus = itemStatus;
            this.TaskType = taskType;
            this.ForReview = forReview;
            this.Issues = issues;
            this.InRedistributeProcess = inRedistributeProcess;
            this.RedistributeProcess = redistributeProcess;
            this.RemoveItemsProcess = removeItemsProcess;
            this.Error = error;
            this.Authz = authz;
            this.Priority = priority;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAssignment" /> class.
        /// </summary>
        public PartialAssignment()
        {
        }
    }
}