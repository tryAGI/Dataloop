
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MqDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exchange")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Exchange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Queue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Route { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MqDetails" /> class.
        /// </summary>
        /// <param name="exchange"></param>
        /// <param name="queue"></param>
        /// <param name="route"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MqDetails(
            string exchange,
            string queue,
            string route)
        {
            this.Exchange = exchange ?? throw new global::System.ArgumentNullException(nameof(exchange));
            this.Queue = queue ?? throw new global::System.ArgumentNullException(nameof(queue));
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MqDetails" /> class.
        /// </summary>
        public MqDetails()
        {
        }
    }
}