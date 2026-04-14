
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICompositionPipelineTemplateState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorDate")]
        public global::System.DateTime? ErrorDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineId")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ECompositionPackageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ECompositionPackageStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionPipelineTemplateState" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="errorDate"></param>
        /// <param name="errorMessage"></param>
        /// <param name="pipelineId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICompositionPipelineTemplateState(
            global::Dataloop.ECompositionPackageStatus status,
            global::System.DateTime? errorDate,
            string? errorMessage,
            string? pipelineId)
        {
            this.ErrorDate = errorDate;
            this.ErrorMessage = errorMessage;
            this.PipelineId = pipelineId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionPipelineTemplateState" /> class.
        /// </summary>
        public ICompositionPipelineTemplateState()
        {
        }
    }
}