
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AggregateProjectVectorsCountInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetIds")]
        public global::System.Collections.Generic.IList<string>? DatasetIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorsQuery")]
        public global::Dataloop.DQLResourceQuery? VectorsQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateProjectVectorsCountInput" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="datasetIds"></param>
        /// <param name="vectorsQuery"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AggregateProjectVectorsCountInput(
            string projectId,
            global::System.Collections.Generic.IList<string>? datasetIds,
            global::Dataloop.DQLResourceQuery? vectorsQuery)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DatasetIds = datasetIds;
            this.VectorsQuery = vectorsQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateProjectVectorsCountInput" /> class.
        /// </summary>
        public AggregateProjectVectorsCountInput()
        {
        }
    }
}