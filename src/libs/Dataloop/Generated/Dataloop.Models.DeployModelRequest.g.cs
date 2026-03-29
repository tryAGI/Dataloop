
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Service Configuration
    /// </summary>
    public sealed partial class DeployModelRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployOperation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelOperationTypesJsonConverter))]
        public global::Dataloop.ModelOperationTypes? DeployOperation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceReference")]
        public global::Dataloop.EntityReference? ServiceReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        public global::Dataloop.ExecutionPipelineStateReference? Pipeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceConfig")]
        public global::Dataloop.Dictionary? ServiceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployModelRequest" /> class.
        /// </summary>
        /// <param name="deployOperation"></param>
        /// <param name="serviceReference"></param>
        /// <param name="pipeline"></param>
        /// <param name="serviceConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeployModelRequest(
            global::Dataloop.ModelOperationTypes? deployOperation,
            global::Dataloop.EntityReference? serviceReference,
            global::Dataloop.ExecutionPipelineStateReference? pipeline,
            global::Dataloop.Dictionary? serviceConfig)
        {
            this.DeployOperation = deployOperation;
            this.ServiceReference = serviceReference;
            this.Pipeline = pipeline;
            this.ServiceConfig = serviceConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployModelRequest" /> class.
        /// </summary>
        public DeployModelRequest()
        {
        }
    }
}