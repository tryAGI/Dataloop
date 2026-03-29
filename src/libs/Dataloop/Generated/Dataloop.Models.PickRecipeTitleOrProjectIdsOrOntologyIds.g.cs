
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickRecipeTitleOrProjectIdsOrOntologyIds
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
        [global::System.Text.Json.Serialization.JsonPropertyName("ontologyIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OntologyIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickRecipeTitleOrProjectIdsOrOntologyIds" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="projectIds"></param>
        /// <param name="ontologyIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickRecipeTitleOrProjectIdsOrOntologyIds(
            string title,
            global::System.Collections.Generic.IList<string> projectIds,
            global::System.Collections.Generic.IList<string> ontologyIds)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
            this.OntologyIds = ontologyIds ?? throw new global::System.ArgumentNullException(nameof(ontologyIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickRecipeTitleOrProjectIdsOrOntologyIds" /> class.
        /// </summary>
        public PickRecipeTitleOrProjectIdsOrOntologyIds()
        {
        }
    }
}