
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class INodePoolDeploymentResourcesLimits
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu")]
        public string? Gpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public string? Memory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu")]
        public string? Cpu { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="INodePoolDeploymentResourcesLimits" /> class.
        /// </summary>
        /// <param name="gpu"></param>
        /// <param name="memory"></param>
        /// <param name="cpu"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public INodePoolDeploymentResourcesLimits(
            string? gpu,
            string? memory,
            string? cpu)
        {
            this.Gpu = gpu;
            this.Memory = memory;
            this.Cpu = cpu;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="INodePoolDeploymentResourcesLimits" /> class.
        /// </summary>
        public INodePoolDeploymentResourcesLimits()
        {
        }
    }
}