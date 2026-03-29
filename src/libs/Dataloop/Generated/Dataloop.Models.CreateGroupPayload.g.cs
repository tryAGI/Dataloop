
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGroupPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="orgId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGroupPayload(
            string name,
            string orgId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupPayload" /> class.
        /// </summary>
        public CreateGroupPayload()
        {
        }
    }
}