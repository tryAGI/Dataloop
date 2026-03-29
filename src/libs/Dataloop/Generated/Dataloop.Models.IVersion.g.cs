
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestForcedVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LatestForcedVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IVersion" /> class.
        /// </summary>
        /// <param name="latestVersion"></param>
        /// <param name="latestForcedVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IVersion(
            string latestVersion,
            bool latestForcedVersion)
        {
            this.LatestVersion = latestVersion ?? throw new global::System.ArgumentNullException(nameof(latestVersion));
            this.LatestForcedVersion = latestForcedVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IVersion" /> class.
        /// </summary>
        public IVersion()
        {
        }
    }
}