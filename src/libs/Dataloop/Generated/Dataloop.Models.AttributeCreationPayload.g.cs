
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttributeCreationPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::System.Collections.Generic.IList<string>? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optional")]
        public bool? Optional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi")]
        public bool? Multi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AttributeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AttributeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<string>? Values { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        public object? Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeCreationPayload" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="scope"></param>
        /// <param name="optional"></param>
        /// <param name="multi"></param>
        /// <param name="values"></param>
        /// <param name="range"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttributeCreationPayload(
            string title,
            string key,
            global::Dataloop.AttributeType type,
            global::System.Collections.Generic.IList<string>? scope,
            bool? optional,
            bool? multi,
            global::System.Collections.Generic.IList<string>? values,
            object? range)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Scope = scope;
            this.Optional = optional;
            this.Multi = multi;
            this.Type = type;
            this.Values = values;
            this.Range = range;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeCreationPayload" /> class.
        /// </summary>
        public AttributeCreationPayload()
        {
        }
    }
}