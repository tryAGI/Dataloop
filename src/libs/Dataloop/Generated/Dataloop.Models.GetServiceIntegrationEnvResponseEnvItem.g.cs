
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetServiceIntegrationEnvResponseEnvItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceIntegrationEnvResponseEnvItem" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetServiceIntegrationEnvResponseEnvItem(
            string value,
            string key)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceIntegrationEnvResponseEnvItem" /> class.
        /// </summary>
        public GetServiceIntegrationEnvResponseEnvItem()
        {
        }
    }
}