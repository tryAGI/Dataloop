
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ItemStatusEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="ItemStatusEventStatus" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="creator"></param>
        /// <param name="status"></param>
        /// <param name="assignmentId"></param>
        /// <param name="taskId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemStatusEventStatus(
            string? timestamp,
            string? creator,
            string? status,
            string? assignmentId,
            string? taskId)
        {
            this.Timestamp = timestamp;
            this.Creator = creator;
            this.Status = status;
            this.AssignmentId = assignmentId;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemStatusEventStatus" /> class.
        /// </summary>
        public ItemStatusEventStatus()
        {
        }
    }
}