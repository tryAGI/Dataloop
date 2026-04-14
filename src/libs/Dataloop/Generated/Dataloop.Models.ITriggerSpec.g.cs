
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ITriggerSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.TriggerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.TriggerType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ITriggerSpecSpec Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        public bool? Global { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ITriggerSpec" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="spec"></param>
        /// <param name="name"></param>
        /// <param name="scope"></param>
        /// <param name="global"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ITriggerSpec(
            global::Dataloop.TriggerType type,
            global::Dataloop.ITriggerSpecSpec spec,
            string? name,
            string? scope,
            bool? global)
        {
            this.Type = type;
            this.Spec = spec ?? throw new global::System.ArgumentNullException(nameof(spec));
            this.Name = name;
            this.Scope = scope;
            this.Global = global;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ITriggerSpec" /> class.
        /// </summary>
        public ITriggerSpec()
        {
        }
    }
}