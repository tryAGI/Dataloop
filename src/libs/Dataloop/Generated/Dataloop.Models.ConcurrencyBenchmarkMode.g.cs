
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConcurrencyBenchmarkMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ConcurrencyBenchmarkModeTypeJsonConverter))]
        public global::Dataloop.ConcurrencyBenchmarkModeType Type { get; set; }

        /// <summary>
        /// max number of concurrent queries
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Concurrency { get; set; }

        /// <summary>
        /// total number of queries to execute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyBenchmarkMode" /> class.
        /// </summary>
        /// <param name="concurrency">
        /// max number of concurrent queries
        /// </param>
        /// <param name="total">
        /// total number of queries to execute
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConcurrencyBenchmarkMode(
            double concurrency,
            double total,
            global::Dataloop.ConcurrencyBenchmarkModeType type)
        {
            this.Type = type;
            this.Concurrency = concurrency;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyBenchmarkMode" /> class.
        /// </summary>
        public ConcurrencyBenchmarkMode()
        {
        }
    }
}