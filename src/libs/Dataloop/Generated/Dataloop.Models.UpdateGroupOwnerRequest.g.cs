
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGroupOwnerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newGroupOwnerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewGroupOwnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGroupOwnerRequest" /> class.
        /// </summary>
        /// <param name="newGroupOwnerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGroupOwnerRequest(
            string newGroupOwnerId)
        {
            this.NewGroupOwnerId = newGroupOwnerId ?? throw new global::System.ArgumentNullException(nameof(newGroupOwnerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGroupOwnerRequest" /> class.
        /// </summary>
        public UpdateGroupOwnerRequest()
        {
        }
    }
}