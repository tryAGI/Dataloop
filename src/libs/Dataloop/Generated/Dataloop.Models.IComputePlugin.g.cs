
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IComputePlugin
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EComputePluginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.EComputePlugin Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useExternalResources")]
        public bool? UseExternalResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>))]
        public global::Dataloop.AnyOf<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>? Config { get; set; }

        /// <summary>
        /// Monitoring plugin spec: Kubernetes manifest overrides plus optional Prometheus placement.<br/>
        /// `prometheusNodePoolName` must match an entry in cluster.nodePools; its nodeSelector/tolerations<br/>
        /// are applied to the Prometheus Deployment and override the pool marked isMonitoringConfiguration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ComputePluginSpecJsonConverter))]
        public global::Dataloop.ComputePluginSpec? Spec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputePlugin" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="useExternalResources"></param>
        /// <param name="config"></param>
        /// <param name="spec">
        /// Monitoring plugin spec: Kubernetes manifest overrides plus optional Prometheus placement.<br/>
        /// `prometheusNodePoolName` must match an entry in cluster.nodePools; its nodeSelector/tolerations<br/>
        /// are applied to the Prometheus Deployment and override the pool marked isMonitoringConfiguration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IComputePlugin(
            global::Dataloop.EComputePlugin name,
            bool? useExternalResources,
            global::Dataloop.AnyOf<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>? config,
            global::Dataloop.ComputePluginSpec? spec)
        {
            this.Name = name;
            this.UseExternalResources = useExternalResources;
            this.Config = config;
            this.Spec = spec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputePlugin" /> class.
        /// </summary>
        public IComputePlugin()
        {
        }
    }
}