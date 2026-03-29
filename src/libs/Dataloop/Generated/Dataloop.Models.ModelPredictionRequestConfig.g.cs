
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Service Configuration
    /// </summary>
    public sealed partial class ModelPredictionRequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceReference")]
        public global::Dataloop.EntityReference? ServiceReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceId")]
        public string? ServiceId { get; set; }

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
        /// Initializes a new instance of the <see cref="ModelPredictionRequestConfig" /> class.
        /// </summary>
        /// <param name="serviceReference"></param>
        /// <param name="serviceId"></param>
        /// <param name="pipeline"></param>
        /// <param name="serviceConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPredictionRequestConfig(
            global::Dataloop.EntityReference? serviceReference,
            string? serviceId,
            global::Dataloop.ExecutionPipelineStateReference? pipeline,
            global::Dataloop.Dictionary? serviceConfig)
        {
            this.ServiceReference = serviceReference;
            this.ServiceId = serviceId;
            this.Pipeline = pipeline;
            this.ServiceConfig = serviceConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPredictionRequestConfig" /> class.
        /// </summary>
        public ModelPredictionRequestConfig()
        {
        }
    }
}