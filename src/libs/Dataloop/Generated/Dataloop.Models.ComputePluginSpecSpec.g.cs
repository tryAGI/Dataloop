
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ComputePluginSpecSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.KubernetesServiceTypeJsonConverter))]
        public global::Dataloop.KubernetesServiceType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Dataloop.ComputePluginSpecSpecResources? Resources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputePluginSpecSpec" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="resources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputePluginSpecSpec(
            global::Dataloop.KubernetesServiceType? type,
            global::Dataloop.ComputePluginSpecSpecResources? resources)
        {
            this.Type = type;
            this.Resources = resources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputePluginSpecSpec" /> class.
        /// </summary>
        public ComputePluginSpecSpec()
        {
        }
    }
}