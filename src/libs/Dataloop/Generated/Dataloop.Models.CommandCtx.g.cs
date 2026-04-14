
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommandCtx
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::Dataloop.HttpContext? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandCtx" /> class.
        /// </summary>
        /// <param name="creator"></param>
        /// <param name="projectId"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommandCtx(
            string creator,
            string? projectId,
            string? orgId,
            global::Dataloop.HttpContext? request)
        {
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.ProjectId = projectId;
            this.OrgId = orgId;
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandCtx" /> class.
        /// </summary>
        public CommandCtx()
        {
        }
    }
}