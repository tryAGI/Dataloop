
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APICompositionModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Dataloop.IModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public global::Dataloop.ICompositionElementState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceConfig")]
        public global::Dataloop.ServiceConfig? ServiceConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelOperationTypesJsonConverter))]
        public global::Dataloop.ModelOperationTypes? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.Dictionary? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::Dataloop.Dictionary? Inputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APICompositionModel" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="state"></param>
        /// <param name="modelId"></param>
        /// <param name="nodeId"></param>
        /// <param name="serviceConfig"></param>
        /// <param name="action"></param>
        /// <param name="metadata"></param>
        /// <param name="inputs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APICompositionModel(
            global::Dataloop.IModel? model,
            global::Dataloop.ICompositionElementState? state,
            string? modelId,
            string? nodeId,
            global::Dataloop.ServiceConfig? serviceConfig,
            global::Dataloop.ModelOperationTypes? action,
            global::Dataloop.Dictionary? metadata,
            global::Dataloop.Dictionary? inputs)
        {
            this.Model = model;
            this.State = state;
            this.ModelId = modelId;
            this.NodeId = nodeId;
            this.ServiceConfig = serviceConfig;
            this.Action = action;
            this.Metadata = metadata;
            this.Inputs = inputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APICompositionModel" /> class.
        /// </summary>
        public APICompositionModel()
        {
        }
    }
}