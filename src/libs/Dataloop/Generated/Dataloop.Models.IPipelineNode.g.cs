
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IPipelineNode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoke")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ToolbarInvoke Invoke { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panel")]
        public string? Panel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::Dataloop.Dictionary? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CustomNodeScopeJsonConverter))]
        public global::Dataloop.CustomNodeScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IPipelineNode" /> class.
        /// </summary>
        /// <param name="invoke"></param>
        /// <param name="displayName"></param>
        /// <param name="icon"></param>
        /// <param name="name"></param>
        /// <param name="panel"></param>
        /// <param name="categories"></param>
        /// <param name="description"></param>
        /// <param name="configuration"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IPipelineNode(
            global::Dataloop.ToolbarInvoke invoke,
            string? displayName,
            string? icon,
            string? name,
            string? panel,
            global::System.Collections.Generic.IList<string>? categories,
            string? description,
            global::Dataloop.Dictionary? configuration,
            global::Dataloop.CustomNodeScope? scope)
        {
            this.DisplayName = displayName;
            this.Invoke = invoke ?? throw new global::System.ArgumentNullException(nameof(invoke));
            this.Icon = icon;
            this.Name = name;
            this.Panel = panel;
            this.Categories = categories;
            this.Description = description;
            this.Configuration = configuration;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPipelineNode" /> class.
        /// </summary>
        public IPipelineNode()
        {
        }
    }
}