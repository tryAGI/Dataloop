
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Provide the deployment configuration and the deployment Type
    /// </summary>
    public sealed partial class UpdateModelDeploymentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary DeploymentConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelOperationTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ModelOperationTypes DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelDeploymentRequest" /> class.
        /// </summary>
        /// <param name="deploymentConfig"></param>
        /// <param name="deploymentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateModelDeploymentRequest(
            global::Dataloop.Dictionary deploymentConfig,
            global::Dataloop.ModelOperationTypes deploymentType)
        {
            this.DeploymentConfig = deploymentConfig ?? throw new global::System.ArgumentNullException(nameof(deploymentConfig));
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelDeploymentRequest" /> class.
        /// </summary>
        public UpdateModelDeploymentRequest()
        {
        }
    }
}