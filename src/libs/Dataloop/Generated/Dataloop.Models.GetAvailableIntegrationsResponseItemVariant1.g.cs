
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvailableIntegrationsResponseItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1Option> Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.IntegrationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IntegrationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableIntegrationsResponseItemVariant1" /> class.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="displayName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvailableIntegrationsResponseItemVariant1(
            global::System.Collections.Generic.IList<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1Option> options,
            string displayName,
            global::Dataloop.IntegrationType type)
        {
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableIntegrationsResponseItemVariant1" /> class.
        /// </summary>
        public GetAvailableIntegrationsResponseItemVariant1()
        {
        }
    }
}