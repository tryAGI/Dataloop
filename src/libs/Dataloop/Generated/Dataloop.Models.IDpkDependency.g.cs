
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkDependency
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
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EDpkScopeJsonConverter))]
        public global::Dataloop.EDpkScope? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeId")]
        public string? ScopeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mandatory")]
        public bool? Mandatory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>))]
        public global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>? Components { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? Integrations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkDependency>? Dependencies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkDependency" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="scope"></param>
        /// <param name="scopeId"></param>
        /// <param name="mandatory"></param>
        /// <param name="components"></param>
        /// <param name="integrations"></param>
        /// <param name="dependencies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkDependency(
            string name,
            string? version,
            global::Dataloop.EDpkScope? scope,
            string? scopeId,
            bool? mandatory,
            global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>? components,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? integrations,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkDependency>? dependencies)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
            this.Scope = scope;
            this.ScopeId = scopeId;
            this.Mandatory = mandatory;
            this.Components = components;
            this.Integrations = integrations;
            this.Dependencies = dependencies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkDependency" /> class.
        /// </summary>
        public IDpkDependency()
        {
        }
    }
}