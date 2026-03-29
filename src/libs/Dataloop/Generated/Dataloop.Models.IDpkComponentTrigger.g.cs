
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkComponentTrigger
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
        public required global::Dataloop.IDpkComponentTriggerSpec Spec { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mandatory")]
        public bool? Mandatory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EComponentServiceOperationJsonConverter))]
        public global::Dataloop.EComponentServiceOperation? Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentTrigger" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="spec"></param>
        /// <param name="namespace"></param>
        /// <param name="name"></param>
        /// <param name="scope"></param>
        /// <param name="global"></param>
        /// <param name="mandatory"></param>
        /// <param name="operation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkComponentTrigger(
            global::Dataloop.TriggerType type,
            global::Dataloop.IDpkComponentTriggerSpec spec,
            string @namespace,
            string? name,
            string? scope,
            bool? global,
            bool? mandatory,
            global::Dataloop.EComponentServiceOperation? operation)
        {
            this.Type = type;
            this.Spec = spec ?? throw new global::System.ArgumentNullException(nameof(spec));
            this.Name = name;
            this.Scope = scope;
            this.Global = global;
            this.Mandatory = mandatory;
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentTrigger" /> class.
        /// </summary>
        public IDpkComponentTrigger()
        {
        }
    }
}