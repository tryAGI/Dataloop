
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IClusterVolumeSecret
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Dataloop.IClusterVolumeSecretItem>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterVolumeSecret" /> class.
        /// </summary>
        /// <param name="secretName"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IClusterVolumeSecret(
            string secretName,
            global::System.Collections.Generic.IList<global::Dataloop.IClusterVolumeSecretItem>? items)
        {
            this.Items = items;
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterVolumeSecret" /> class.
        /// </summary>
        public IClusterVolumeSecret()
        {
        }
    }
}