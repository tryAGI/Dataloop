
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialAPIDpk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseId")]
        public string? BaseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codebase")]
        public global::Dataloop.Codebase? Codebase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trusted")]
        public bool? Trusted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EDpkScopeJsonConverter))]
        public global::Dataloop.EDpkScope? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest")]
        public bool? Latest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.IDpkMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Dataloop.IAppContext? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialContext")]
        public global::Dataloop.IDpkInitialContext? InitialContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>))]
        public global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>? Components { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkDependency>? Dependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAPIDpk" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="baseId"></param>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="version"></param>
        /// <param name="attributes"></param>
        /// <param name="updatedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="icon"></param>
        /// <param name="tags"></param>
        /// <param name="codebase"></param>
        /// <param name="trusted"></param>
        /// <param name="scope"></param>
        /// <param name="latest"></param>
        /// <param name="metadata"></param>
        /// <param name="context"></param>
        /// <param name="initialContext"></param>
        /// <param name="components"></param>
        /// <param name="dependencies"></param>
        /// <param name="variables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialAPIDpk(
            string? id,
            string? baseId,
            string? name,
            string? url,
            string? version,
            object? attributes,
            global::System.DateTime? updatedAt,
            global::System.DateTime? createdAt,
            string? creator,
            string? displayName,
            string? description,
            string? icon,
            global::System.Collections.Generic.IList<string>? tags,
            global::Dataloop.Codebase? codebase,
            bool? trusted,
            global::Dataloop.EDpkScope? scope,
            bool? latest,
            global::Dataloop.IDpkMetadata? metadata,
            global::Dataloop.IAppContext? context,
            global::Dataloop.IDpkInitialContext? initialContext,
            global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>? components,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkDependency>? dependencies,
            global::System.Collections.Generic.Dictionary<string, string>? variables)
        {
            this.Id = id;
            this.BaseId = baseId;
            this.Name = name;
            this.Url = url;
            this.Version = version;
            this.Attributes = attributes;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Creator = creator;
            this.DisplayName = displayName;
            this.Description = description;
            this.Icon = icon;
            this.Tags = tags;
            this.Codebase = codebase;
            this.Trusted = trusted;
            this.Scope = scope;
            this.Latest = latest;
            this.Metadata = metadata;
            this.Context = context;
            this.InitialContext = initialContext;
            this.Components = components;
            this.Dependencies = dependencies;
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAPIDpk" /> class.
        /// </summary>
        public PartialAPIDpk()
        {
        }
    }
}