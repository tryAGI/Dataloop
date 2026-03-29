
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchAssignmentPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssignmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asynced")]
        public bool? Asynced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchAssignmentPayload" /> class.
        /// </summary>
        /// <param name="assignmentId"></param>
        /// <param name="asynced"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchAssignmentPayload(
            string assignmentId,
            bool? asynced)
        {
            this.AssignmentId = assignmentId ?? throw new global::System.ArgumentNullException(nameof(assignmentId));
            this.Asynced = asynced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchAssignmentPayload" /> class.
        /// </summary>
        public BatchAssignmentPayload()
        {
        }
    }
}