
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Per-resource overrides (key = metadata.name + kind, e.g. prometheusDeployment).
    /// </summary>
    public sealed partial class ComputePluginResourceManifests
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}