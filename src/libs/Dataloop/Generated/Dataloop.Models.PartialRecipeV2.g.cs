
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialRecipeV2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("ontology")]
        public global::Dataloop.PartialRecipeV2Ontology? Ontology { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolsSettings")]
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ToolOptions>? ToolsSettings { get; set; }

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
        public global::Dataloop.AuthZBlockRecipeV2Context? Authz { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("v2")]
        public bool? V2 { get; set; }

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
        /// Initializes a new instance of the <see cref="PartialRecipeV2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="creator"></param>
        /// <param name="title"></param>
        /// <param name="projectIds"></param>
        /// <param name="ontology"></param>
        /// <param name="toolsSettings"></param>
        /// <param name="uiSettings"></param>
        /// <param name="metadata"></param>
        /// <param name="authz"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="v2"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialRecipeV2(
            string? id,
            string? creator,
            string? title,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::Dataloop.PartialRecipeV2Ontology? ontology,
            global::System.Collections.Generic.Dictionary<string, global::Dataloop.ToolOptions>? toolsSettings,
            global::Dataloop.Dictionary? uiSettings,
            global::Dataloop.Metadata2? metadata,
            global::Dataloop.AuthZBlockRecipeV2Context? authz,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            bool? v2,
            global::Dataloop.RecipeType? type)
        {
            this.Id = id;
            this.Creator = creator;
            this.Title = title;
            this.ProjectIds = projectIds;
            this.Ontology = ontology;
            this.ToolsSettings = toolsSettings;
            this.UiSettings = uiSettings;
            this.Metadata = metadata;
            this.Authz = authz;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.V2 = v2;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRecipeV2" /> class.
        /// </summary>
        public PartialRecipeV2()
        {
        }
    }
}