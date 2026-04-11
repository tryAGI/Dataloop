
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICompositionDatasetState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceId")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionId")]
        public string? ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        public global::Dataloop.ICompositionDatasetStateDataset? Dataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CompositionElementStatusJsonConverter))]
        public global::Dataloop.CompositionElementStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorDate")]
        public global::System.DateTime? ErrorDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionDatasetState" /> class.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="executionId"></param>
        /// <param name="dataset"></param>
        /// <param name="status"></param>
        /// <param name="errorMessage"></param>
        /// <param name="errorDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICompositionDatasetState(
            string? serviceId,
            string? executionId,
            global::Dataloop.ICompositionDatasetStateDataset? dataset,
            global::Dataloop.CompositionElementStatus? status,
            string? errorMessage,
            global::System.DateTime? errorDate)
        {
            this.ServiceId = serviceId;
            this.ExecutionId = executionId;
            this.Dataset = dataset;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.ErrorDate = errorDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionDatasetState" /> class.
        /// </summary>
        public ICompositionDatasetState()
        {
        }
    }
}