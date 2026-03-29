
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartialRecipePayloadExamples
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bad")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.APIBadExample> Bad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("good")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.APIGoodExample> Good { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRecipePayloadExamples" /> class.
        /// </summary>
        /// <param name="bad"></param>
        /// <param name="good"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialRecipePayloadExamples(
            global::System.Collections.Generic.IList<global::Dataloop.APIBadExample> bad,
            global::System.Collections.Generic.IList<global::Dataloop.APIGoodExample> good)
        {
            this.Bad = bad ?? throw new global::System.ArgumentNullException(nameof(bad));
            this.Good = good ?? throw new global::System.ArgumentNullException(nameof(good));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRecipePayloadExamples" /> class.
        /// </summary>
        public PartialRecipePayloadExamples()
        {
        }
    }
}