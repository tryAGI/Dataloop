
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickRecipeV2TitleOrProjectIdsOrOntology
    {
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
        public required global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntologyOntology Ontology { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickRecipeV2TitleOrProjectIdsOrOntology" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="projectIds"></param>
        /// <param name="ontology"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickRecipeV2TitleOrProjectIdsOrOntology(
            string title,
            global::System.Collections.Generic.IList<string> projectIds,
            global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntologyOntology ontology)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
            this.Ontology = ontology ?? throw new global::System.ArgumentNullException(nameof(ontology));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickRecipeV2TitleOrProjectIdsOrOntology" /> class.
        /// </summary>
        public PickRecipeV2TitleOrProjectIdsOrOntology()
        {
        }
    }
}