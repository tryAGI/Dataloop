
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Service Configuration
    /// </summary>
    public sealed partial class EvaluateModelRequestConfig
    {
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
        /// Initializes a new instance of the <see cref="EvaluateModelRequestConfig" /> class.
        /// </summary>
        /// <param name="serviceReference"></param>
        /// <param name="pipeline"></param>
        /// <param name="serviceConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluateModelRequestConfig(
            global::Dataloop.EntityReference? serviceReference,
            global::Dataloop.ExecutionPipelineStateReference? pipeline,
            global::Dataloop.Dictionary? serviceConfig)
        {
            this.ServiceReference = serviceReference;
            this.Pipeline = pipeline;
            this.ServiceConfig = serviceConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateModelRequestConfig" /> class.
        /// </summary>
        public EvaluateModelRequestConfig()
        {
        }
    }
}