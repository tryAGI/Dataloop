
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneRecipePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shallow")]
        public bool? Shallow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::Dataloop.RecipeType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roots")]
        public global::System.Collections.Generic.IList<global::Dataloop.LabelTree>? Roots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultApp")]
        public string? DefaultApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneRecipePayload" /> class.
        /// </summary>
        /// <param name="shallow"></param>
        /// <param name="type"></param>
        /// <param name="roots"></param>
        /// <param name="defaultApp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloneRecipePayload(
            bool? shallow,
            global::Dataloop.RecipeType? type,
            global::System.Collections.Generic.IList<global::Dataloop.LabelTree>? roots,
            string? defaultApp)
        {
            this.Shallow = shallow;
            this.Type = type;
            this.Roots = roots;
            this.DefaultApp = defaultApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneRecipePayload" /> class.
        /// </summary>
        public CloneRecipePayload()
        {
        }
    }
}