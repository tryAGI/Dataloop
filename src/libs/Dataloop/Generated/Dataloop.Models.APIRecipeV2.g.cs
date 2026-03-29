
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIRecipeV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ontology")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIRecipeV2Ontology Ontology { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labelScript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelScript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolsSettings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Dataloop.APIToolOptionsV2> ToolsSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uiSettings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary UiSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool V2 { get; set; }

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
        /// Initializes a new instance of the <see cref="APIRecipeV2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="creator"></param>
        /// <param name="title"></param>
        /// <param name="projectIds"></param>
        /// <param name="ontology"></param>
        /// <param name="labelScript"></param>
        /// <param name="toolsSettings"></param>
        /// <param name="uiSettings"></param>
        /// <param name="metadata"></param>
        /// <param name="v2"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIRecipeV2(
            string id,
            string url,
            string creator,
            string title,
            global::System.Collections.Generic.IList<string> projectIds,
            global::Dataloop.APIRecipeV2Ontology ontology,
            string labelScript,
            global::System.Collections.Generic.Dictionary<string, global::Dataloop.APIToolOptionsV2> toolsSettings,
            global::Dataloop.Dictionary uiSettings,
            global::Dataloop.APIMetadata metadata,
            bool v2,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            global::Dataloop.RecipeType? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
            this.Ontology = ontology ?? throw new global::System.ArgumentNullException(nameof(ontology));
            this.LabelScript = labelScript ?? throw new global::System.ArgumentNullException(nameof(labelScript));
            this.ToolsSettings = toolsSettings ?? throw new global::System.ArgumentNullException(nameof(toolsSettings));
            this.UiSettings = uiSettings ?? throw new global::System.ArgumentNullException(nameof(uiSettings));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.V2 = v2;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIRecipeV2" /> class.
        /// </summary>
        public APIRecipeV2()
        {
        }
    }
}