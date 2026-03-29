
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTaskItemScoresPayloadContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relative")]
        public string? Relative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTaskItemScoresPayloadContext" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="relative"></param>
        /// <param name="userId"></param>
        /// <param name="itemId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTaskItemScoresPayloadContext(
            string taskId,
            string? relative,
            string? userId,
            string? itemId)
        {
            this.Relative = relative;
            this.UserId = userId;
            this.ItemId = itemId;
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTaskItemScoresPayloadContext" /> class.
        /// </summary>
        public DeleteTaskItemScoresPayloadContext()
        {
        }
    }
}