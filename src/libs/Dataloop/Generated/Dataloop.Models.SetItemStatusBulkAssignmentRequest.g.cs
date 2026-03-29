
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// : Assignment status payload
    /// </summary>
    public sealed partial class SetItemStatusBulkAssignmentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusPayload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AssignmentStatusPayload StatusPayload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ItemIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetItemStatusBulkAssignmentRequest" /> class.
        /// </summary>
        /// <param name="statusPayload"></param>
        /// <param name="itemIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetItemStatusBulkAssignmentRequest(
            global::Dataloop.AssignmentStatusPayload statusPayload,
            global::System.Collections.Generic.IList<string> itemIds)
        {
            this.StatusPayload = statusPayload ?? throw new global::System.ArgumentNullException(nameof(statusPayload));
            this.ItemIds = itemIds ?? throw new global::System.ArgumentNullException(nameof(itemIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetItemStatusBulkAssignmentRequest" /> class.
        /// </summary>
        public SetItemStatusBulkAssignmentRequest()
        {
        }
    }
}