
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IExternalMonitoringConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IExternalMonitoringConfig" /> class.
        /// </summary>
        /// <param name="port"></param>
        /// <param name="serviceName"></param>
        /// <param name="namespace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IExternalMonitoringConfig(
            string port,
            string serviceName,
            string? @namespace)
        {
            this.Port = port ?? throw new global::System.ArgumentNullException(nameof(port));
            this.Namespace = @namespace;
            this.ServiceName = serviceName ?? throw new global::System.ArgumentNullException(nameof(serviceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IExternalMonitoringConfig" /> class.
        /// </summary>
        public IExternalMonitoringConfig()
        {
        }
    }
}