
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateDatasetOptionsMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeDistribution")]
        public global::System.Collections.Generic.Dictionary<string, double>? SizeDistribution { get; set; }

        /// <summary>
        /// amount of metadata keys that will become searchable metadata keys
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Searchable { get; set; }

        /// <summary>
        /// percent of the metadata values that will be removed from the generated items<br/>
        /// key selection is random
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nulls")]
        public double? Nulls { get; set; }

        /// <summary>
        /// list of numbers 0-1<br/>
        /// each number correlates to a key in the keys array<br/>
        /// 1 means ALL items will have the same value for the corresponding key<br/>
        /// 0 means NO items will have the same value for the corresponding key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valuesDistribution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> ValuesDistribution { get; set; }

        /// <summary>
        /// when specified - JSON size will be inflated into the specified size
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minBytes")]
        public double? MinBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDatasetOptionsMetadata" /> class.
        /// </summary>
        /// <param name="searchable">
        /// amount of metadata keys that will become searchable metadata keys
        /// </param>
        /// <param name="valuesDistribution">
        /// list of numbers 0-1<br/>
        /// each number correlates to a key in the keys array<br/>
        /// 1 means ALL items will have the same value for the corresponding key<br/>
        /// 0 means NO items will have the same value for the corresponding key
        /// </param>
        /// <param name="sizeDistribution"></param>
        /// <param name="nulls">
        /// percent of the metadata values that will be removed from the generated items<br/>
        /// key selection is random
        /// </param>
        /// <param name="minBytes">
        /// when specified - JSON size will be inflated into the specified size
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateDatasetOptionsMetadata(
            double searchable,
            global::System.Collections.Generic.IList<double> valuesDistribution,
            global::System.Collections.Generic.Dictionary<string, double>? sizeDistribution,
            double? nulls,
            double? minBytes)
        {
            this.SizeDistribution = sizeDistribution;
            this.Searchable = searchable;
            this.Nulls = nulls;
            this.ValuesDistribution = valuesDistribution ?? throw new global::System.ArgumentNullException(nameof(valuesDistribution));
            this.MinBytes = minBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDatasetOptionsMetadata" /> class.
        /// </summary>
        public GenerateDatasetOptionsMetadata()
        {
        }
    }
}