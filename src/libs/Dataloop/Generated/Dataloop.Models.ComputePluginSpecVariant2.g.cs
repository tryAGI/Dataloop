
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ComputePluginSpecVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prometheusNodePoolName")]
        public string? PrometheusNodePoolName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputePluginSpecVariant2" /> class.
        /// </summary>
        /// <param name="prometheusNodePoolName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputePluginSpecVariant2(
            string? prometheusNodePoolName)
        {
            this.PrometheusNodePoolName = prometheusNodePoolName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputePluginSpecVariant2" /> class.
        /// </summary>
        public ComputePluginSpecVariant2()
        {
        }
    }
}