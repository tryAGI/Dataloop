
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IComputeCluster
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kubernetesVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KubernetesVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EClusterProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.EClusterProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodePools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.INodePool> NodePools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::Dataloop.IComputePlugin>? Plugins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IComputeAuthentication Authentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentConfiguration")]
        public global::Dataloop.IDeploymentConfiguration? DeploymentConfiguration { get; set; }

        /// <summary>
        /// Run:ai configuration for GPU workload scheduling (scheduler, fractional GPU)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runAi")]
        public global::Dataloop.IRunAiConfig? RunAi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeCluster" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="endpoint"></param>
        /// <param name="kubernetesVersion"></param>
        /// <param name="provider"></param>
        /// <param name="nodePools"></param>
        /// <param name="metadata"></param>
        /// <param name="authentication"></param>
        /// <param name="plugins"></param>
        /// <param name="deploymentConfiguration"></param>
        /// <param name="runAi">
        /// Run:ai configuration for GPU workload scheduling (scheduler, fractional GPU)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IComputeCluster(
            string name,
            string endpoint,
            string kubernetesVersion,
            global::Dataloop.EClusterProvider provider,
            global::System.Collections.Generic.IList<global::Dataloop.INodePool> nodePools,
            global::Dataloop.Dictionary metadata,
            global::Dataloop.IComputeAuthentication authentication,
            global::System.Collections.Generic.IList<global::Dataloop.IComputePlugin>? plugins,
            global::Dataloop.IDeploymentConfiguration? deploymentConfiguration,
            global::Dataloop.IRunAiConfig? runAi)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.KubernetesVersion = kubernetesVersion ?? throw new global::System.ArgumentNullException(nameof(kubernetesVersion));
            this.Provider = provider;
            this.NodePools = nodePools ?? throw new global::System.ArgumentNullException(nameof(nodePools));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Plugins = plugins;
            this.Authentication = authentication ?? throw new global::System.ArgumentNullException(nameof(authentication));
            this.DeploymentConfiguration = deploymentConfiguration;
            this.RunAi = runAi;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeCluster" /> class.
        /// </summary>
        public IComputeCluster()
        {
        }
    }
}