
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialRecipe
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

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
        public global::System.Collections.Generic.IList<global::Dataloop.ToolInstruction>? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::Dataloop.PartialRecipeExamples? Examples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customActions")]
        public global::System.Collections.Generic.IList<global::Dataloop.CustomAction>? CustomActions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uiSettings")]
        public global::Dataloop.Dictionary? UiSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.Metadata2? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authz")]
        public global::Dataloop.AuthZBlockRecipeContext? Authz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecatedBy")]
        public string? DeprecatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

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
        /// Initializes a new instance of the <see cref="PartialRecipe" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="creator"></param>
        /// <param name="title"></param>
        /// <param name="projectIds"></param>
        /// <param name="description"></param>
        /// <param name="ontologyIds"></param>
        /// <param name="instructions"></param>
        /// <param name="examples"></param>
        /// <param name="customActions"></param>
        /// <param name="uiSettings"></param>
        /// <param name="metadata"></param>
        /// <param name="authz"></param>
        /// <param name="deprecatedBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialRecipe(
            string? id,
            string? creator,
            string? title,
            global::System.Collections.Generic.IList<string>? projectIds,
            string? description,
            global::System.Collections.Generic.IList<string>? ontologyIds,
            global::System.Collections.Generic.IList<global::Dataloop.ToolInstruction>? instructions,
            global::Dataloop.PartialRecipeExamples? examples,
            global::System.Collections.Generic.IList<global::Dataloop.CustomAction>? customActions,
            global::Dataloop.Dictionary? uiSettings,
            global::Dataloop.Metadata2? metadata,
            global::Dataloop.AuthZBlockRecipeContext? authz,
            string? deprecatedBy,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            global::Dataloop.RecipeType? type)
        {
            this.Id = id;
            this.Creator = creator;
            this.Title = title;
            this.ProjectIds = projectIds;
            this.Description = description;
            this.OntologyIds = ontologyIds;
            this.Instructions = instructions;
            this.Examples = examples;
            this.CustomActions = customActions;
            this.UiSettings = uiSettings;
            this.Metadata = metadata;
            this.Authz = authz;
            this.DeprecatedBy = deprecatedBy;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRecipe" /> class.
        /// </summary>
        public PartialRecipe()
        {
        }
    }
}