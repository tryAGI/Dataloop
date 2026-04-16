
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ComputeMetadataVariant2
    {
        /// <summary>
        /// Tracks which gateway was last deployed in front of serve-agent.<br/>
        /// Used to cleanup the previous gateway when switching between Nginx gateway and direct access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serveAgentGateway")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ComputeMetadataVariant2ServeAgentGatewayJsonConverter))]
        public global::Dataloop.ComputeMetadataVariant2ServeAgentGateway? ServeAgentGateway { get; set; }

        /// <summary>
        /// When set, applied as spec.loadBalancerSourceRanges on serve-agent / nginx gateway Services<br/>
        /// when their type is LoadBalancer or NodePort (ignored for ClusterIP).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serveAgentLoadBalancerSourceRanges")]
        public global::System.Collections.Generic.IList<string>? ServeAgentLoadBalancerSourceRanges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serveAgentServiceType")]
        public string? ServeAgentServiceType { get; set; }

        /// <summary>
        /// GKE only: when true with an internal LoadBalancer, adds<br/>
        /// networking.gke.io/internal-load-balancer-allow-global-access on serve-agent / nginx gateway Services.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serveAgentInternalLoadBalancerAllowGlobalAccess")]
        public bool? ServeAgentInternalLoadBalancerAllowGlobalAccess { get; set; }

        /// <summary>
        /// AWS: comma-separated public subnet IDs so the NLB is internet-facing when nodes are in private subnets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serveAgentLoadBalancerSubnetIds")]
        public global::System.Collections.Generic.IList<string>? ServeAgentLoadBalancerSubnetIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serveAgentInternalLoadBalancer")]
        public bool? ServeAgentInternalLoadBalancer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serveAgentDNS")]
        public string? ServeAgentDNS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheRunnerFS")]
        public string? CacheRunnerFS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filestoreServer")]
        public string? FilestoreServer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheRunner")]
        public global::Dataloop.CacheRunner? CacheRunner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nfsServer")]
        public string? NfsServer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentScriptUpdatedTime")]
        public string? AgentScriptUpdatedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeSelector")]
        public global::System.Collections.Generic.IList<global::Dataloop.DriverNodeSelector>? NodeSelector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tolerations")]
        public global::System.Collections.Generic.IList<global::Dataloop.DriverToleration>? Tolerations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedInstances")]
        public global::System.Collections.Generic.IList<global::Dataloop.DataloopPodType>? AllowedInstances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serveAgentIP")]
        public string? ServeAgentIP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serveAgentEndpoint")]
        public string? ServeAgentEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeMetadataVariant2" /> class.
        /// </summary>
        /// <param name="serveAgentGateway">
        /// Tracks which gateway was last deployed in front of serve-agent.<br/>
        /// Used to cleanup the previous gateway when switching between Nginx gateway and direct access.
        /// </param>
        /// <param name="serveAgentLoadBalancerSourceRanges">
        /// When set, applied as spec.loadBalancerSourceRanges on serve-agent / nginx gateway Services<br/>
        /// when their type is LoadBalancer or NodePort (ignored for ClusterIP).
        /// </param>
        /// <param name="serveAgentServiceType"></param>
        /// <param name="serveAgentInternalLoadBalancerAllowGlobalAccess">
        /// GKE only: when true with an internal LoadBalancer, adds<br/>
        /// networking.gke.io/internal-load-balancer-allow-global-access on serve-agent / nginx gateway Services.
        /// </param>
        /// <param name="serveAgentLoadBalancerSubnetIds">
        /// AWS: comma-separated public subnet IDs so the NLB is internet-facing when nodes are in private subnets
        /// </param>
        /// <param name="serveAgentInternalLoadBalancer"></param>
        /// <param name="serveAgentDNS"></param>
        /// <param name="cacheRunnerFS"></param>
        /// <param name="filestoreServer"></param>
        /// <param name="cacheRunner"></param>
        /// <param name="nfsServer"></param>
        /// <param name="agentScriptUpdatedTime"></param>
        /// <param name="nodeSelector"></param>
        /// <param name="tolerations"></param>
        /// <param name="allowedInstances"></param>
        /// <param name="serveAgentIP"></param>
        /// <param name="serveAgentEndpoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputeMetadataVariant2(
            global::Dataloop.ComputeMetadataVariant2ServeAgentGateway? serveAgentGateway,
            global::System.Collections.Generic.IList<string>? serveAgentLoadBalancerSourceRanges,
            string? serveAgentServiceType,
            bool? serveAgentInternalLoadBalancerAllowGlobalAccess,
            global::System.Collections.Generic.IList<string>? serveAgentLoadBalancerSubnetIds,
            bool? serveAgentInternalLoadBalancer,
            string? serveAgentDNS,
            string? cacheRunnerFS,
            string? filestoreServer,
            global::Dataloop.CacheRunner? cacheRunner,
            string? nfsServer,
            string? agentScriptUpdatedTime,
            global::System.Collections.Generic.IList<global::Dataloop.DriverNodeSelector>? nodeSelector,
            global::System.Collections.Generic.IList<global::Dataloop.DriverToleration>? tolerations,
            global::System.Collections.Generic.IList<global::Dataloop.DataloopPodType>? allowedInstances,
            string? serveAgentIP,
            string? serveAgentEndpoint)
        {
            this.ServeAgentGateway = serveAgentGateway;
            this.ServeAgentLoadBalancerSourceRanges = serveAgentLoadBalancerSourceRanges;
            this.ServeAgentServiceType = serveAgentServiceType;
            this.ServeAgentInternalLoadBalancerAllowGlobalAccess = serveAgentInternalLoadBalancerAllowGlobalAccess;
            this.ServeAgentLoadBalancerSubnetIds = serveAgentLoadBalancerSubnetIds;
            this.ServeAgentInternalLoadBalancer = serveAgentInternalLoadBalancer;
            this.ServeAgentDNS = serveAgentDNS;
            this.CacheRunnerFS = cacheRunnerFS;
            this.FilestoreServer = filestoreServer;
            this.CacheRunner = cacheRunner;
            this.NfsServer = nfsServer;
            this.AgentScriptUpdatedTime = agentScriptUpdatedTime;
            this.NodeSelector = nodeSelector;
            this.Tolerations = tolerations;
            this.AllowedInstances = allowedInstances;
            this.ServeAgentIP = serveAgentIP;
            this.ServeAgentEndpoint = serveAgentEndpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeMetadataVariant2" /> class.
        /// </summary>
        public ComputeMetadataVariant2()
        {
        }
    }
}