
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddOrgToProjectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrgToProjectRequest" /> class.
        /// </summary>
        /// <param name="orgId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddOrgToProjectRequest(
            string orgId)
        {
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrgToProjectRequest" /> class.
        /// </summary>
        public AddOrgToProjectRequest()
        {
        }
    }
}