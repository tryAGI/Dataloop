
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddSubGroupRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddSubGroupRequest" /> class.
        /// </summary>
        /// <param name="subGroupId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddSubGroupRequest(
            string subGroupId)
        {
            this.SubGroupId = subGroupId ?? throw new global::System.ArgumentNullException(nameof(subGroupId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddSubGroupRequest" /> class.
        /// </summary>
        public AddSubGroupRequest()
        {
        }
    }
}