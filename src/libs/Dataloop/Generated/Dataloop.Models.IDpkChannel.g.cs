
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkChannel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("mandatory")]
        public bool? Mandatory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Global { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IDpkChannelMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.NotificationEntityContext Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkFilter>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkChannel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="global"></param>
        /// <param name="metadata"></param>
        /// <param name="context"></param>
        /// <param name="mandatory"></param>
        /// <param name="icon"></param>
        /// <param name="description"></param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkChannel(
            string name,
            bool global,
            global::Dataloop.IDpkChannelMetadata metadata,
            global::Dataloop.NotificationEntityContext context,
            bool? mandatory,
            string? icon,
            string? description,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkFilter>? filters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Mandatory = mandatory;
            this.Icon = icon;
            this.Description = description;
            this.Global = global;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkChannel" /> class.
        /// </summary>
        public IDpkChannel()
        {
        }
    }
}