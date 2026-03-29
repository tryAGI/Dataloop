
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GcsIntegrationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object PrivateKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GcsIntegrationConfig" /> class.
        /// </summary>
        /// <param name="privateKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GcsIntegrationConfig(
            object privateKey)
        {
            this.PrivateKey = privateKey ?? throw new global::System.ArgumentNullException(nameof(privateKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GcsIntegrationConfig" /> class.
        /// </summary>
        public GcsIntegrationConfig()
        {
        }
    }
}