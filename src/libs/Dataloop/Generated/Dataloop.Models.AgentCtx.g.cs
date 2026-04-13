
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentCtx
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceId")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCtx" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="orgId"></param>
        /// <param name="serviceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCtx(
            string? projectId,
            string? orgId,
            string? serviceId)
        {
            this.ProjectId = projectId;
            this.OrgId = orgId;
            this.ServiceId = serviceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCtx" /> class.
        /// </summary>
        public AgentCtx()
        {
        }
    }
}