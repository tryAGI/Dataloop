
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthUserAttributes
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
        public global::System.Collections.Generic.IList<string>? Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::Dataloop.GroupCtx>? Groups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgs")]
        public global::System.Collections.Generic.IList<string>? Orgs { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("orgRole")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("given_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GivenName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returningUser")]
        public bool? ReturningUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membershipType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DLEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DLEntityType MembershipType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membershipEntityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MembershipEntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.RoleJsonConverter))]
        public global::Dataloop.Role? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("superuser")]
        public bool? Superuser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture")]
        public string? Picture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("via")]
        public string? Via { get; set; }

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
        /// Initializes a new instance of the <see cref="AuthUserAttributes" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="email"></param>
        /// <param name="type"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="orgRole"></param>
        /// <param name="created"></param>
        /// <param name="domain"></param>
        /// <param name="givenName"></param>
        /// <param name="membershipType"></param>
        /// <param name="membershipEntityId"></param>
        /// <param name="url"></param>
        /// <param name="lastName"></param>
        /// <param name="avatar"></param>
        /// <param name="projects"></param>
        /// <param name="groups"></param>
        /// <param name="org"></param>
        /// <param name="orgs"></param>
        /// <param name="lastLogin"></param>
        /// <param name="interest"></param>
        /// <param name="boarded"></param>
        /// <param name="hash"></param>
        /// <param name="timezone"></param>
        /// <param name="returningUser"></param>
        /// <param name="role"></param>
        /// <param name="superuser"></param>
        /// <param name="picture"></param>
        /// <param name="via"></param>
        /// <param name="orgBot"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserAttributes(
            string id,
            string username,
            string firstName,
            string email,
            string type,
            double createdAt,
            double updatedAt,
            string orgRole,
            bool created,
            string domain,
            string givenName,
            global::Dataloop.DLEntityType membershipType,
            string membershipEntityId,
            string? url,
            string? lastName,
            string? avatar,
            global::System.Collections.Generic.IList<string>? projects,
            global::System.Collections.Generic.IList<global::Dataloop.GroupCtx>? groups,
            string? org,
            global::System.Collections.Generic.IList<string>? orgs,
            double? lastLogin,
            string? interest,
            bool? boarded,
            string? hash,
            string? timezone,
            bool? returningUser,
            global::Dataloop.Role? role,
            bool? superuser,
            string? picture,
            string? via,
            bool? orgBot)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.LastName = lastName;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Avatar = avatar;
            this.Projects = projects;
            this.Groups = groups;
            this.Org = org;
            this.Orgs = orgs;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.LastLogin = lastLogin;
            this.Interest = interest;
            this.Boarded = boarded;
            this.Hash = hash;
            this.Timezone = timezone;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.OrgRole = orgRole ?? throw new global::System.ArgumentNullException(nameof(orgRole));
            this.Created = created;
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.GivenName = givenName ?? throw new global::System.ArgumentNullException(nameof(givenName));
            this.ReturningUser = returningUser;
            this.MembershipType = membershipType;
            this.MembershipEntityId = membershipEntityId ?? throw new global::System.ArgumentNullException(nameof(membershipEntityId));
            this.Role = role;
            this.Superuser = superuser;
            this.Picture = picture;
            this.Via = via;
            this.OrgBot = orgBot;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserAttributes" /> class.
        /// </summary>
        public AuthUserAttributes()
        {
        }
    }
}