
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIPostDpk
    {
        /// <summary>
        /// The app name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The app version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// List of attributes linked to the app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// The display Name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// description of the dpk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// icon style - should present in the ui platform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// List of tags linked to the app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codebase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Codebase Codebase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EDpkScopeJsonConverter))]
        public global::Dataloop.EDpkScope? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trusted")]
        public bool? Trusted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>> Components { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Dataloop.IAppContext? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPostDpk" /> class.
        /// </summary>
        /// <param name="name">
        /// The app name
        /// </param>
        /// <param name="codebase"></param>
        /// <param name="components"></param>
        /// <param name="version">
        /// The app version
        /// </param>
        /// <param name="attributes">
        /// List of attributes linked to the app
        /// </param>
        /// <param name="displayName">
        /// The display Name
        /// </param>
        /// <param name="description">
        /// description of the dpk
        /// </param>
        /// <param name="icon">
        /// icon style - should present in the ui platform
        /// </param>
        /// <param name="tags">
        /// List of tags linked to the app
        /// </param>
        /// <param name="scope"></param>
        /// <param name="trusted"></param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIPostDpk(
            string name,
            global::Dataloop.Codebase codebase,
            global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>> components,
            string? version,
            object? attributes,
            string? displayName,
            string? description,
            string? icon,
            global::System.Collections.Generic.IList<string>? tags,
            global::Dataloop.EDpkScope? scope,
            bool? trusted,
            global::Dataloop.IAppContext? context)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
            this.Attributes = attributes;
            this.DisplayName = displayName;
            this.Description = description;
            this.Icon = icon;
            this.Tags = tags;
            this.Codebase = codebase ?? throw new global::System.ArgumentNullException(nameof(codebase));
            this.Scope = scope;
            this.Trusted = trusted;
            this.Components = components;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPostDpk" /> class.
        /// </summary>
        public APIPostDpk()
        {
        }
    }
}