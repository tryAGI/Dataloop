
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetEtlOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipVideoEtl")]
        public bool? SkipVideoEtl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipImageEtl")]
        public bool? SkipImageEtl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetEtlOptions" /> class.
        /// </summary>
        /// <param name="skipVideoEtl"></param>
        /// <param name="skipImageEtl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetEtlOptions(
            bool? skipVideoEtl,
            bool? skipImageEtl)
        {
            this.SkipVideoEtl = skipVideoEtl;
            this.SkipImageEtl = skipImageEtl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetEtlOptions" /> class.
        /// </summary>
        public DatasetEtlOptions()
        {
        }
    }
}