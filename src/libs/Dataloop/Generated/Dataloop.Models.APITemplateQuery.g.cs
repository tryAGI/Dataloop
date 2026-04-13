
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APITemplateQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CursorPageAPIPipelineTemplate Global { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CursorPageAPIPipelineTemplate Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CursorPageAPIPipelineTemplate Org { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APITemplateQuery" /> class.
        /// </summary>
        /// <param name="global"></param>
        /// <param name="project"></param>
        /// <param name="org"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APITemplateQuery(
            global::Dataloop.CursorPageAPIPipelineTemplate global,
            global::Dataloop.CursorPageAPIPipelineTemplate project,
            global::Dataloop.CursorPageAPIPipelineTemplate org)
        {
            this.Global = global ?? throw new global::System.ArgumentNullException(nameof(global));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APITemplateQuery" /> class.
        /// </summary>
        public APITemplateQuery()
        {
        }
    }
}