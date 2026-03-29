
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOntologyPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roots")]
        public global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayloadTreeV1>? Roots { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public bool? System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<string>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOntologyPayload" /> class.
        /// </summary>
        /// <param name="roots"></param>
        /// <param name="title"></param>
        /// <param name="projectIds"></param>
        /// <param name="system"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOntologyPayload(
            global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayloadTreeV1>? roots,
            string? title,
            global::System.Collections.Generic.IList<string>? projectIds,
            bool? system,
            global::System.Collections.Generic.IList<string>? attributes)
        {
            this.Roots = roots;
            this.Title = title;
            this.ProjectIds = projectIds;
            this.System = system;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOntologyPayload" /> class.
        /// </summary>
        public CreateOntologyPayload()
        {
        }
    }
}