
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RangeOrFeatureTierRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("higher")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Higher { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lower")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Lower { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeOrFeatureTierRange" /> class.
        /// </summary>
        /// <param name="higher"></param>
        /// <param name="lower"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RangeOrFeatureTierRange(
            double higher,
            double lower)
        {
            this.Higher = higher;
            this.Lower = lower;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeOrFeatureTierRange" /> class.
        /// </summary>
        public RangeOrFeatureTierRange()
        {
        }
    }
}