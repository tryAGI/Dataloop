
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class INodePoolDeploymentResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.INodePoolDeploymentResourcesRequests Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.INodePoolDeploymentResourcesLimits Limits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="INodePoolDeploymentResources" /> class.
        /// </summary>
        /// <param name="requests"></param>
        /// <param name="limits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public INodePoolDeploymentResources(
            global::Dataloop.INodePoolDeploymentResourcesRequests requests,
            global::Dataloop.INodePoolDeploymentResourcesLimits limits)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="INodePoolDeploymentResources" /> class.
        /// </summary>
        public INodePoolDeploymentResources()
        {
        }
    }
}