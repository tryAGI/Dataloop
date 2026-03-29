
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDeploymentConfigurationDefaultResourcesRequests
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Memory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cpu { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDeploymentConfigurationDefaultResourcesRequests" /> class.
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="cpu"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDeploymentConfigurationDefaultResourcesRequests(
            string memory,
            string cpu)
        {
            this.Memory = memory ?? throw new global::System.ArgumentNullException(nameof(memory));
            this.Cpu = cpu ?? throw new global::System.ArgumentNullException(nameof(cpu));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDeploymentConfigurationDefaultResourcesRequests" /> class.
        /// </summary>
        public IDeploymentConfigurationDefaultResourcesRequests()
        {
        }
    }
}