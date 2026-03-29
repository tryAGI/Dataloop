
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateItemsSchemaInputIndexingOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleSize")]
        public double? SampleSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItemsSchemaInputIndexingOptions" /> class.
        /// </summary>
        /// <param name="sampleSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateItemsSchemaInputIndexingOptions(
            double? sampleSize)
        {
            this.SampleSize = sampleSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItemsSchemaInputIndexingOptions" /> class.
        /// </summary>
        public UpdateItemsSchemaInputIndexingOptions()
        {
        }
    }
}