
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreParametersScoreContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignmentId")]
        public string? AssignmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreParametersScoreContext" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="assignmentId"></param>
        /// <param name="taskId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreParametersScoreContext(
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? userId,
            string? assignmentId,
            string? taskId)
        {
            this.UserId = userId;
            this.AssignmentId = assignmentId;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreParametersScoreContext" /> class.
        /// </summary>
        public ScoreParametersScoreContext()
        {
        }
    }
}