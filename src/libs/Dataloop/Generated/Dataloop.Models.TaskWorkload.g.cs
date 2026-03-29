
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskWorkload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigneeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssigneeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("load")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Load { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkload" /> class.
        /// </summary>
        /// <param name="assigneeId"></param>
        /// <param name="load"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskWorkload(
            string assigneeId,
            double load)
        {
            this.AssigneeId = assigneeId ?? throw new global::System.ArgumentNullException(nameof(assigneeId));
            this.Load = load;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkload" /> class.
        /// </summary>
        public TaskWorkload()
        {
        }
    }
}