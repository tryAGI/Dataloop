
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickStartInputAnyMaxBytesOrMaxMessages
    {
        /// <summary>
        /// limits number of messages in a batch by its size
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxBytes")]
        public double? MaxBytes { get; set; }

        /// <summary>
        /// determines how many messages will be processed at once<br/>
        /// Default Value: Infinity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMessages")]
        public double? MaxMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickStartInputAnyMaxBytesOrMaxMessages" /> class.
        /// </summary>
        /// <param name="maxBytes">
        /// limits number of messages in a batch by its size
        /// </param>
        /// <param name="maxMessages">
        /// determines how many messages will be processed at once<br/>
        /// Default Value: Infinity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickStartInputAnyMaxBytesOrMaxMessages(
            double? maxBytes,
            double? maxMessages)
        {
            this.MaxBytes = maxBytes;
            this.MaxMessages = maxMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickStartInputAnyMaxBytesOrMaxMessages" /> class.
        /// </summary>
        public PickStartInputAnyMaxBytesOrMaxMessages()
        {
        }
    }
}