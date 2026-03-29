
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchMemberPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denyMembersManagement")]
        public bool? DenyMembersManagement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Role Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchMemberPayload" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="denyMembersManagement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchMemberPayload(
            global::Dataloop.Role role,
            bool? denyMembersManagement)
        {
            this.DenyMembersManagement = denyMembersManagement;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchMemberPayload" /> class.
        /// </summary>
        public PatchMemberPayload()
        {
        }
    }
}