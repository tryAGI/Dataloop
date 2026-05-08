
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class INodePool
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
        [global::System.Text.Json.Serialization.JsonPropertyName("isDlTypeDefault")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDlTypeDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMonitoringConfiguration")]
        public bool? IsMonitoringConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dlTypes")]
        public global::System.Collections.Generic.IList<string>? DlTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tolerations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.Toleration> Tolerations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeSelector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary NodeSelector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preemptible")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Preemptible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentResources")]
        public global::Dataloop.INodePoolDeploymentResources? DeploymentResources { get; set; }

        /// <summary>
        /// When true, workloads target Run:ai-managed nodes; inject scheduler + annotations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runAiManaged")]
        public bool? RunAiManaged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="INodePool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isDlTypeDefault"></param>
        /// <param name="tolerations"></param>
        /// <param name="description"></param>
        /// <param name="nodeSelector"></param>
        /// <param name="preemptible"></param>
        /// <param name="isMonitoringConfiguration"></param>
        /// <param name="dlTypes"></param>
        /// <param name="deploymentResources"></param>
        /// <param name="runAiManaged">
        /// When true, workloads target Run:ai-managed nodes; inject scheduler + annotations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public INodePool(
            string name,
            bool isDlTypeDefault,
            global::System.Collections.Generic.IList<global::Dataloop.Toleration> tolerations,
            string description,
            global::Dataloop.Dictionary nodeSelector,
            bool preemptible,
            bool? isMonitoringConfiguration,
            global::System.Collections.Generic.IList<string>? dlTypes,
            global::Dataloop.INodePoolDeploymentResources? deploymentResources,
            bool? runAiManaged)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsDlTypeDefault = isDlTypeDefault;
            this.IsMonitoringConfiguration = isMonitoringConfiguration;
            this.DlTypes = dlTypes;
            this.Tolerations = tolerations ?? throw new global::System.ArgumentNullException(nameof(tolerations));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.NodeSelector = nodeSelector ?? throw new global::System.ArgumentNullException(nameof(nodeSelector));
            this.Preemptible = preemptible;
            this.DeploymentResources = deploymentResources;
            this.RunAiManaged = runAiManaged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="INodePool" /> class.
        /// </summary>
        public INodePool()
        {
        }
    }
}