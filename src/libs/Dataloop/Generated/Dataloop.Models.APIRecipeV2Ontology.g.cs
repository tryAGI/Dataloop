
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIRecipeV2Ontology
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structureIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> StructureIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labelScope")]
        public global::Dataloop.APILabelScopeV2? LabelScope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ontologyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OntologyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIRecipeV2Ontology" /> class.
        /// </summary>
        /// <param name="structureIds"></param>
        /// <param name="attributes"></param>
        /// <param name="ontologyId"></param>
        /// <param name="labelScope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIRecipeV2Ontology(
            global::System.Collections.Generic.IList<string> structureIds,
            global::System.Collections.Generic.IList<string> attributes,
            string ontologyId,
            global::Dataloop.APILabelScopeV2? labelScope)
        {
            this.StructureIds = structureIds ?? throw new global::System.ArgumentNullException(nameof(structureIds));
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.LabelScope = labelScope;
            this.OntologyId = ontologyId ?? throw new global::System.ArgumentNullException(nameof(ontologyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIRecipeV2Ontology" /> class.
        /// </summary>
        public APIRecipeV2Ontology()
        {
        }
    }
}