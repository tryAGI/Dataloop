
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICompositionFilterState
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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CompositionElementStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CompositionElementStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterId")]
        public string? FilterId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionFilterState" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="errorDate"></param>
        /// <param name="errorMessage"></param>
        /// <param name="filterId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICompositionFilterState(
            global::Dataloop.CompositionElementStatus status,
            global::System.DateTime? errorDate,
            string? errorMessage,
            string? filterId)
        {
            this.ErrorDate = errorDate;
            this.ErrorMessage = errorMessage;
            this.Status = status;
            this.FilterId = filterId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionFilterState" /> class.
        /// </summary>
        public ICompositionFilterState()
        {
        }
    }
}