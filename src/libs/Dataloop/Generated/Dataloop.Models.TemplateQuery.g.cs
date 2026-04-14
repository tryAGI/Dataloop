
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.QueryStringTemplate Global { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.QueryStringTemplate Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.QueryStringTemplate Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateQuery" /> class.
        /// </summary>
        /// <param name="global"></param>
        /// <param name="org"></param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateQuery(
            global::Dataloop.QueryStringTemplate global,
            global::Dataloop.QueryStringTemplate org,
            global::Dataloop.QueryStringTemplate project)
        {
            this.Global = global ?? throw new global::System.ArgumentNullException(nameof(global));
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateQuery" /> class.
        /// </summary>
        public TemplateQuery()
        {
        }
    }
}