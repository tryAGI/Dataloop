
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDeploymentConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::Dataloop.IClusterVolume>? Volumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityContext")]
        public global::Dataloop.IDeploymentSecurityContext? SecurityContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentVariables")]
        public global::System.Collections.Generic.IList<global::Dataloop.IClusterEnvironmentVariable>? EnvironmentVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry")]
        public global::Dataloop.IComputeRegistry? Registry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceAccountName")]
        public string? ServiceAccountName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalRequestsUrl")]
        public string? InternalRequestsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultResources")]
        public global::Dataloop.IDeploymentConfigurationDefaultResources? DefaultResources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDeploymentConfiguration" /> class.
        /// </summary>
        /// <param name="volumes"></param>
        /// <param name="securityContext"></param>
        /// <param name="environmentVariables"></param>
        /// <param name="registry"></param>
        /// <param name="serviceAccountName"></param>
        /// <param name="internalRequestsUrl"></param>
        /// <param name="defaultResources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDeploymentConfiguration(
            global::System.Collections.Generic.IList<global::Dataloop.IClusterVolume>? volumes,
            global::Dataloop.IDeploymentSecurityContext? securityContext,
            global::System.Collections.Generic.IList<global::Dataloop.IClusterEnvironmentVariable>? environmentVariables,
            global::Dataloop.IComputeRegistry? registry,
            string? serviceAccountName,
            string? internalRequestsUrl,
            global::Dataloop.IDeploymentConfigurationDefaultResources? defaultResources)
        {
            this.Volumes = volumes;
            this.SecurityContext = securityContext;
            this.EnvironmentVariables = environmentVariables;
            this.Registry = registry;
            this.ServiceAccountName = serviceAccountName;
            this.InternalRequestsUrl = internalRequestsUrl;
            this.DefaultResources = defaultResources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDeploymentConfiguration" /> class.
        /// </summary>
        public IDeploymentConfiguration()
        {
        }
    }
}