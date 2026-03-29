
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvailableIntegrationsResponseItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.GetAvailableIntegrationsResponseItemVariant2Option> Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IconUrl { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableIntegrationsResponseItemVariant2" /> class.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="iconUrl"></param>
        /// <param name="displayName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvailableIntegrationsResponseItemVariant2(
            global::System.Collections.Generic.IList<global::Dataloop.GetAvailableIntegrationsResponseItemVariant2Option> options,
            string iconUrl,
            string displayName,
            string type)
        {
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.IconUrl = iconUrl ?? throw new global::System.ArgumentNullException(nameof(iconUrl));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableIntegrationsResponseItemVariant2" /> class.
        /// </summary>
        public GetAvailableIntegrationsResponseItemVariant2()
        {
        }
    }
}