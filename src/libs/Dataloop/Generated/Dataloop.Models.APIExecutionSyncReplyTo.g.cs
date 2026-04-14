
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Used when running execution in sync mode
    /// </summary>
    public sealed partial class APIExecutionSyncReplyTo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Route { get; set; }

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
        /// Initializes a new instance of the <see cref="APIExecutionSyncReplyTo" /> class.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="exchange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIExecutionSyncReplyTo(
            string route,
            string exchange)
        {
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
            this.Exchange = exchange ?? throw new global::System.ArgumentNullException(nameof(exchange));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIExecutionSyncReplyTo" /> class.
        /// </summary>
        public APIExecutionSyncReplyTo()
        {
        }
    }
}