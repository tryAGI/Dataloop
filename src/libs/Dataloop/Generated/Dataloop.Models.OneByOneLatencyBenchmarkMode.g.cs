
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OneByOneLatencyBenchmarkMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.OneByOneLatencyBenchmarkModeTypeJsonConverter))]
        public global::Dataloop.OneByOneLatencyBenchmarkModeType Type { get; set; }

        /// <summary>
        /// number of times to execute each query test case
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OneByOneLatencyBenchmarkMode" /> class.
        /// </summary>
        /// <param name="count">
        /// number of times to execute each query test case
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OneByOneLatencyBenchmarkMode(
            double count,
            global::Dataloop.OneByOneLatencyBenchmarkModeType type)
        {
            this.Type = type;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneByOneLatencyBenchmarkMode" /> class.
        /// </summary>
        public OneByOneLatencyBenchmarkMode()
        {
        }
    }
}