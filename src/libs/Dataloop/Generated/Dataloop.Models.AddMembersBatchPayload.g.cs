
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddMembersBatchPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interest")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.UserInterestTypeJsonConverter))]
        public global::Dataloop.UserInterestType? Interest { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_response")]
        public bool? SkipResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_welcome_email")]
        public bool? SkipWelcomeEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Role Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMembersBatchPayload" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="users"></param>
        /// <param name="interest"></param>
        /// <param name="via"></param>
        /// <param name="denyMembersManagement"></param>
        /// <param name="skipResponse"></param>
        /// <param name="skipWelcomeEmail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddMembersBatchPayload(
            global::Dataloop.Role role,
            global::System.Collections.Generic.IList<string> users,
            global::Dataloop.UserInterestType? interest,
            string? via,
            bool? denyMembersManagement,
            bool? skipResponse,
            bool? skipWelcomeEmail)
        {
            this.Interest = interest;
            this.Via = via;
            this.DenyMembersManagement = denyMembersManagement;
            this.SkipResponse = skipResponse;
            this.SkipWelcomeEmail = skipWelcomeEmail;
            this.Role = role;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMembersBatchPayload" /> class.
        /// </summary>
        public AddMembersBatchPayload()
        {
        }
    }
}