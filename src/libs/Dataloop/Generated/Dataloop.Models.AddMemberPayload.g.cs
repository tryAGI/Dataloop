
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddMemberPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("via")]
        public string? Via { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denyMembersManagement")]
        public bool? DenyMembersManagement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_add_groups")]
        public bool? CanAddGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_welcome_email")]
        public bool? SkipWelcomeEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_response")]
        public bool? SkipResponse { get; set; }

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
        /// Initializes a new instance of the <see cref="AddMemberPayload" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="via"></param>
        /// <param name="denyMembersManagement"></param>
        /// <param name="canAddGroups"></param>
        /// <param name="skipWelcomeEmail"></param>
        /// <param name="skipResponse"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddMemberPayload(
            global::Dataloop.Role role,
            string? via,
            bool? denyMembersManagement,
            bool? canAddGroups,
            bool? skipWelcomeEmail,
            bool? skipResponse)
        {
            this.Via = via;
            this.DenyMembersManagement = denyMembersManagement;
            this.CanAddGroups = canAddGroups;
            this.SkipWelcomeEmail = skipWelcomeEmail;
            this.SkipResponse = skipResponse;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMemberPayload" /> class.
        /// </summary>
        public AddMemberPayload()
        {
        }
    }
}