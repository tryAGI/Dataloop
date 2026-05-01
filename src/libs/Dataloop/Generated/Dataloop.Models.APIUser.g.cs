
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.GroupCtx> Groups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>))]
        public global::Dataloop.AnyOf<global::Dataloop.APIOrg, string>? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Orgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastLogin")]
        public double? LastLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interest")]
        public string? Interest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boarded")]
        public bool? Boarded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public bool? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviteEmail")]
        public string? InviteEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        public string? Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guest")]
        public global::Dataloop.APIUserGuest? Guest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denyMembersManagement")]
        public bool? DenyMembersManagement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultProjectRole")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.RoleJsonConverter))]
        public global::Dataloop.Role? DefaultProjectRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousLogin")]
        public double? PreviousLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgBot")]
        public bool? OrgBot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUser" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="email"></param>
        /// <param name="projects"></param>
        /// <param name="groups"></param>
        /// <param name="orgs"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="lastName"></param>
        /// <param name="avatar"></param>
        /// <param name="org"></param>
        /// <param name="lastLogin"></param>
        /// <param name="interest"></param>
        /// <param name="boarded"></param>
        /// <param name="timezone"></param>
        /// <param name="created"></param>
        /// <param name="inviteEmail"></param>
        /// <param name="status"></param>
        /// <param name="member"></param>
        /// <param name="guest"></param>
        /// <param name="denyMembersManagement"></param>
        /// <param name="defaultProjectRole"></param>
        /// <param name="previousLogin"></param>
        /// <param name="orgBot"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIUser(
            string id,
            double createdAt,
            double updatedAt,
            string username,
            string firstName,
            string email,
            global::System.Collections.Generic.IList<string> projects,
            global::System.Collections.Generic.IList<global::Dataloop.GroupCtx> groups,
            global::System.Collections.Generic.IList<string> orgs,
            string type,
            string? url,
            string? lastName,
            string? avatar,
            global::Dataloop.AnyOf<global::Dataloop.APIOrg, string>? org,
            double? lastLogin,
            string? interest,
            bool? boarded,
            string? timezone,
            bool? created,
            string? inviteEmail,
            string? status,
            string? member,
            global::Dataloop.APIUserGuest? guest,
            bool? denyMembersManagement,
            global::Dataloop.Role? defaultProjectRole,
            double? previousLogin,
            bool? orgBot)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.LastName = lastName;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Avatar = avatar;
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
            this.Org = org;
            this.Orgs = orgs ?? throw new global::System.ArgumentNullException(nameof(orgs));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.LastLogin = lastLogin;
            this.Interest = interest;
            this.Boarded = boarded;
            this.Timezone = timezone;
            this.Created = created;
            this.InviteEmail = inviteEmail;
            this.Status = status;
            this.Member = member;
            this.Guest = guest;
            this.DenyMembersManagement = denyMembersManagement;
            this.DefaultProjectRole = defaultProjectRole;
            this.PreviousLogin = previousLogin;
            this.OrgBot = orgBot;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUser" /> class.
        /// </summary>
        public APIUser()
        {
        }
    }
}