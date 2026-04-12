
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICompositionChannelState
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CompositionChannelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CompositionChannelStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionChannelState" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="errorDate"></param>
        /// <param name="errorMessage"></param>
        /// <param name="channelId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICompositionChannelState(
            global::Dataloop.CompositionChannelStatus status,
            global::System.DateTime? errorDate,
            string? errorMessage,
            string? channelId)
        {
            this.ErrorDate = errorDate;
            this.ErrorMessage = errorMessage;
            this.Status = status;
            this.ChannelId = channelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionChannelState" /> class.
        /// </summary>
        public ICompositionChannelState()
        {
        }
    }
}