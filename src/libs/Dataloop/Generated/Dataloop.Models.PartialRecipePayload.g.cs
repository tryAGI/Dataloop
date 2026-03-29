
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartialRecipePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        public global::System.Collections.Generic.IList<string>? ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ontologyIds")]
        public global::System.Collections.Generic.IList<string>? OntologyIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public global::System.Collections.Generic.IList<global::Dataloop.APIInstruction>? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::Dataloop.PartialRecipePayloadExamples? Examples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customActions")]
        public global::System.Collections.Generic.IList<global::Dataloop.APICustomAction>? CustomActions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uiSettings")]
        public global::Dataloop.Dictionary? UiSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.APIMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::Dataloop.RecipeType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRecipePayload" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="projectIds"></param>
        /// <param name="description"></param>
        /// <param name="ontologyIds"></param>
        /// <param name="instructions"></param>
        /// <param name="examples"></param>
        /// <param name="customActions"></param>
        /// <param name="uiSettings"></param>
        /// <param name="metadata"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialRecipePayload(
            string? title,
            global::System.Collections.Generic.IList<string>? projectIds,
            string? description,
            global::System.Collections.Generic.IList<string>? ontologyIds,
            global::System.Collections.Generic.IList<global::Dataloop.APIInstruction>? instructions,
            global::Dataloop.PartialRecipePayloadExamples? examples,
            global::System.Collections.Generic.IList<global::Dataloop.APICustomAction>? customActions,
            global::Dataloop.Dictionary? uiSettings,
            global::Dataloop.APIMetadata? metadata,
            global::Dataloop.RecipeType? type)
        {
            this.Title = title;
            this.ProjectIds = projectIds;
            this.Description = description;
            this.OntologyIds = ontologyIds;
            this.Instructions = instructions;
            this.Examples = examples;
            this.CustomActions = customActions;
            this.UiSettings = uiSettings;
            this.Metadata = metadata;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRecipePayload" /> class.
        /// </summary>
        public PartialRecipePayload()
        {
        }
    }
}