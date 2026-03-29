
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RoleEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?> Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        public string? OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgName")]
        public string? OrgName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleEntry" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="projectId"></param>
        /// <param name="orgId"></param>
        /// <param name="orgName"></param>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoleEntry(
            global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?> role,
            string? projectId,
            string? orgId,
            string? orgName,
            bool? active)
        {
            this.Role = role;
            this.ProjectId = projectId;
            this.OrgId = orgId;
            this.OrgName = orgName;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleEntry" /> class.
        /// </summary>
        public RoleEntry()
        {
        }
    }
}