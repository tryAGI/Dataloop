
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MergeDatasetParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withItemsAnnotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WithItemsAnnotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withMetadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WithMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeDatasetParams" /> class.
        /// </summary>
        /// <param name="withItemsAnnotations"></param>
        /// <param name="withMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MergeDatasetParams(
            bool withItemsAnnotations,
            bool withMetadata)
        {
            this.WithItemsAnnotations = withItemsAnnotations;
            this.WithMetadata = withMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeDatasetParams" /> class.
        /// </summary>
        public MergeDatasetParams()
        {
        }
    }
}