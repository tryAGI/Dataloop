
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreParametersOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeHistogramItems")]
        public bool? IncludeHistogramItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreParametersOptions" /> class.
        /// </summary>
        /// <param name="includeHistogramItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreParametersOptions(
            bool? includeHistogramItems)
        {
            this.IncludeHistogramItems = includeHistogramItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreParametersOptions" /> class.
        /// </summary>
        public ScoreParametersOptions()
        {
        }
    }
}