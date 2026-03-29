
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartialRecipeExamples
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bad")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.Example> Bad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("good")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.GoodExample> Good { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRecipeExamples" /> class.
        /// </summary>
        /// <param name="bad"></param>
        /// <param name="good"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialRecipeExamples(
            global::System.Collections.Generic.IList<global::Dataloop.Example> bad,
            global::System.Collections.Generic.IList<global::Dataloop.GoodExample> good)
        {
            this.Bad = bad ?? throw new global::System.ArgumentNullException(nameof(bad));
            this.Good = good ?? throw new global::System.ArgumentNullException(nameof(good));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRecipeExamples" /> class.
        /// </summary>
        public PartialRecipeExamples()
        {
        }
    }
}