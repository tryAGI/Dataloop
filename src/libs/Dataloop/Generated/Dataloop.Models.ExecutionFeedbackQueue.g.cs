
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionFeedbackQueue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Routing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exchange")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Exchange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionFeedbackQueue" /> class.
        /// </summary>
        /// <param name="routing"></param>
        /// <param name="exchange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionFeedbackQueue(
            string routing,
            string exchange)
        {
            this.Routing = routing ?? throw new global::System.ArgumentNullException(nameof(routing));
            this.Exchange = exchange ?? throw new global::System.ArgumentNullException(nameof(exchange));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionFeedbackQueue" /> class.
        /// </summary>
        public ExecutionFeedbackQueue()
        {
        }
    }
}