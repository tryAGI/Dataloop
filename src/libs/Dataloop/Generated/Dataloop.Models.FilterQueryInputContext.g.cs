
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterQueryInputContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<string>? Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<string>? Datasets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        public global::System.Collections.Generic.IList<string>? ProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterQueryInputContext" /> class.
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="datasets"></param>
        /// <param name="projectIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterQueryInputContext(
            global::System.Collections.Generic.IList<string>? projects,
            global::System.Collections.Generic.IList<string>? datasets,
            global::System.Collections.Generic.IList<string>? projectIds)
        {
            this.Projects = projects;
            this.Datasets = datasets;
            this.ProjectIds = projectIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterQueryInputContext" /> class.
        /// </summary>
        public FilterQueryInputContext()
        {
        }
    }
}