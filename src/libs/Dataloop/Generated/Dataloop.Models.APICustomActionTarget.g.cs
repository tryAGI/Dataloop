
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APICustomActionTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelId { get; set; }

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
        /// Initializes a new instance of the <see cref="APICustomActionTarget" /> class.
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="ontologyId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APICustomActionTarget(
            string labelId,
            string ontologyId)
        {
            this.LabelId = labelId ?? throw new global::System.ArgumentNullException(nameof(labelId));
            this.OntologyId = ontologyId ?? throw new global::System.ArgumentNullException(nameof(ontologyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APICustomActionTarget" /> class.
        /// </summary>
        public APICustomActionTarget()
        {
        }
    }
}