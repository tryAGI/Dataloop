
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ComputePluginResourceManifests2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ComputePluginResourceManifestsSpec Spec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputePluginResourceManifests2" /> class.
        /// </summary>
        /// <param name="spec"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputePluginResourceManifests2(
            global::Dataloop.ComputePluginResourceManifestsSpec spec)
        {
            this.Spec = spec ?? throw new global::System.ArgumentNullException(nameof(spec));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputePluginResourceManifests2" /> class.
        /// </summary>
        public ComputePluginResourceManifests2()
        {
        }
    }
}