
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDeploymentConfigurationDefaultResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IDeploymentConfigurationDefaultResourcesLimits Limits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IDeploymentConfigurationDefaultResourcesRequests Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDeploymentConfigurationDefaultResources" /> class.
        /// </summary>
        /// <param name="limits"></param>
        /// <param name="requests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDeploymentConfigurationDefaultResources(
            global::Dataloop.IDeploymentConfigurationDefaultResourcesLimits limits,
            global::Dataloop.IDeploymentConfigurationDefaultResourcesRequests requests)
        {
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDeploymentConfigurationDefaultResources" /> class.
        /// </summary>
        public IDeploymentConfigurationDefaultResources()
        {
        }
    }
}