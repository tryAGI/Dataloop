
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkMetadataCommands
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("services")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Services { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkMetadataCommands" /> class.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="apps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkMetadataCommands(
            string services,
            string apps)
        {
            this.Services = services ?? throw new global::System.ArgumentNullException(nameof(services));
            this.Apps = apps ?? throw new global::System.ArgumentNullException(nameof(apps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkMetadataCommands" /> class.
        /// </summary>
        public IDpkMetadataCommands()
        {
        }
    }
}