
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateDatasetOptionsAnnotationsMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeDistribution")]
        public global::System.Collections.Generic.Dictionary<string, double>? SizeDistribution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDatasetOptionsAnnotationsMetadata" /> class.
        /// </summary>
        /// <param name="sizeDistribution"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateDatasetOptionsAnnotationsMetadata(
            global::System.Collections.Generic.Dictionary<string, double>? sizeDistribution)
        {
            this.SizeDistribution = sizeDistribution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDatasetOptionsAnnotationsMetadata" /> class.
        /// </summary>
        public GenerateDatasetOptionsAnnotationsMetadata()
        {
        }
    }
}