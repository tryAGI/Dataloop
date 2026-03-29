
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArchiveAnnotationToStorageRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Concurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SampleSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DQLResourceQuery Spec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveAnnotationToStorageRequest" /> class.
        /// </summary>
        /// <param name="concurrency"></param>
        /// <param name="sampleSize"></param>
        /// <param name="spec"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArchiveAnnotationToStorageRequest(
            double concurrency,
            double sampleSize,
            global::Dataloop.DQLResourceQuery spec)
        {
            this.Concurrency = concurrency;
            this.SampleSize = sampleSize;
            this.Spec = spec ?? throw new global::System.ArgumentNullException(nameof(spec));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveAnnotationToStorageRequest" /> class.
        /// </summary>
        public ArchiveAnnotationToStorageRequest()
        {
        }
    }
}