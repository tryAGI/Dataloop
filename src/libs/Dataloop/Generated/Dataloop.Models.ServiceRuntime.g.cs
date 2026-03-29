
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceRuntime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public double? Concurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("singleAgent")]
        public bool? SingleAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRuntime" /> class.
        /// </summary>
        /// <param name="concurrency"></param>
        /// <param name="singleAgent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceRuntime(
            double? concurrency,
            bool? singleAgent)
        {
            this.Concurrency = concurrency;
            this.SingleAgent = singleAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRuntime" /> class.
        /// </summary>
        public ServiceRuntime()
        {
        }
    }
}