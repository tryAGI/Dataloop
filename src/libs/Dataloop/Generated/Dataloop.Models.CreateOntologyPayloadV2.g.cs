
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOntologyPayloadV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roots")]
        public global::System.Collections.Generic.IList<string>? Roots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<string>? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structureIds")]
        public global::System.Collections.Generic.IList<string>? StructureIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public bool? System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v2")]
        public bool? V2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOntologyPayloadV2" /> class.
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="roots"></param>
        /// <param name="attributes"></param>
        /// <param name="structureIds"></param>
        /// <param name="system"></param>
        /// <param name="v2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOntologyPayloadV2(
            global::System.Collections.Generic.IList<string> projectIds,
            global::System.Collections.Generic.IList<string>? roots,
            global::System.Collections.Generic.IList<string>? attributes,
            global::System.Collections.Generic.IList<string>? structureIds,
            bool? system,
            bool? v2)
        {
            this.Roots = roots;
            this.Attributes = attributes;
            this.StructureIds = structureIds;
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
            this.System = system;
            this.V2 = v2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOntologyPayloadV2" /> class.
        /// </summary>
        public CreateOntologyPayloadV2()
        {
        }
    }
}