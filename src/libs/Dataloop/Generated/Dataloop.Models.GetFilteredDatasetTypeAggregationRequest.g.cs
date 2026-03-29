
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFilteredDatasetTypeAggregationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignmentId")]
        public string? AssignmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creators")]
        public global::System.Collections.Generic.IList<string>? Creators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilteredDatasetTypeAggregationRequest" /> class.
        /// </summary>
        /// <param name="assignmentId"></param>
        /// <param name="taskId"></param>
        /// <param name="creators"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFilteredDatasetTypeAggregationRequest(
            string? assignmentId,
            string? taskId,
            global::System.Collections.Generic.IList<string>? creators)
        {
            this.AssignmentId = assignmentId;
            this.TaskId = taskId;
            this.Creators = creators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilteredDatasetTypeAggregationRequest" /> class.
        /// </summary>
        public GetFilteredDatasetTypeAggregationRequest()
        {
        }
    }
}