
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relativeId")]
        public string? RelativeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relative")]
        public string? Relative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationId")]
        public string? AnnotationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignmentId")]
        public string? AssignmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreContext" /> class.
        /// </summary>
        /// <param name="relativeId"></param>
        /// <param name="relative"></param>
        /// <param name="modelId"></param>
        /// <param name="annotationId"></param>
        /// <param name="itemId"></param>
        /// <param name="assignmentId"></param>
        /// <param name="userId"></param>
        /// <param name="taskId"></param>
        /// <param name="datasetId"></param>
        /// <param name="projectId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreContext(
            string? relativeId,
            string? relative,
            string? modelId,
            string? annotationId,
            string? itemId,
            string? assignmentId,
            string? userId,
            string? taskId,
            string? datasetId,
            string? projectId)
        {
            this.RelativeId = relativeId;
            this.Relative = relative;
            this.ModelId = modelId;
            this.AnnotationId = annotationId;
            this.ItemId = itemId;
            this.AssignmentId = assignmentId;
            this.UserId = userId;
            this.TaskId = taskId;
            this.DatasetId = datasetId;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreContext" /> class.
        /// </summary>
        public ScoreContext()
        {
        }
    }
}