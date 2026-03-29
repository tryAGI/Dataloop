
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickDataStreamConfigAnyMaxConcurrentReadersOrRetentionOrCompression
    {
        /// <summary>
        /// max number of concurrent reader this stream allows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxConcurrentReaders")]
        public double? MaxConcurrentReaders { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention")]
        public global::Dataloop.PartialMsNumberbytes3Anumber? Retention { get; set; }

        /// <summary>
        /// enables compression<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        public bool? Compression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickDataStreamConfigAnyMaxConcurrentReadersOrRetentionOrCompression" /> class.
        /// </summary>
        /// <param name="maxConcurrentReaders">
        /// max number of concurrent reader this stream allows
        /// </param>
        /// <param name="retention">
        /// Make all properties in T optional
        /// </param>
        /// <param name="compression">
        /// enables compression<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickDataStreamConfigAnyMaxConcurrentReadersOrRetentionOrCompression(
            double? maxConcurrentReaders,
            global::Dataloop.PartialMsNumberbytes3Anumber? retention,
            bool? compression)
        {
            this.MaxConcurrentReaders = maxConcurrentReaders;
            this.Retention = retention;
            this.Compression = compression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickDataStreamConfigAnyMaxConcurrentReadersOrRetentionOrCompression" /> class.
        /// </summary>
        public PickDataStreamConfigAnyMaxConcurrentReadersOrRetentionOrCompression()
        {
        }
    }
}