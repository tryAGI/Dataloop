
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartialRecipePayloadV2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("labelScript")]
        public string? LabelScript { get; set; }

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
        /// Initializes a new instance of the <see cref="PartialRecipePayloadV2" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="projectIds"></param>
        /// <param name="labelScript"></param>
        /// <param name="uiSettings"></param>
        /// <param name="metadata"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialRecipePayloadV2(
            string? title,
            global::System.Collections.Generic.IList<string>? projectIds,
            string? labelScript,
            global::Dataloop.Dictionary? uiSettings,
            global::Dataloop.APIMetadata? metadata,
            global::Dataloop.RecipeType? type)
        {
            this.Title = title;
            this.ProjectIds = projectIds;
            this.LabelScript = labelScript;
            this.UiSettings = uiSettings;
            this.Metadata = metadata;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRecipePayloadV2" /> class.
        /// </summary>
        public PartialRecipePayloadV2()
        {
        }
    }
}