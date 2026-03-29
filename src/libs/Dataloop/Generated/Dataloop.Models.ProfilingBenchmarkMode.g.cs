
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProfilingBenchmarkMode
    {
        /// <summary>
        /// command will execute query profile for each test case
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ProfilingBenchmarkModeTypeJsonConverter))]
        public global::Dataloop.ProfilingBenchmarkModeType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilingBenchmarkMode" /> class.
        /// </summary>
        /// <param name="type">
        /// command will execute query profile for each test case
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfilingBenchmarkMode(
            global::Dataloop.ProfilingBenchmarkModeType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilingBenchmarkMode" /> class.
        /// </summary>
        public ProfilingBenchmarkMode()
        {
        }
    }
}