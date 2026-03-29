
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowsCounters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasksCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TasksCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignmentsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AssignmentsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuesCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IssuesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ReviewsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowsCounters" /> class.
        /// </summary>
        /// <param name="tasksCount"></param>
        /// <param name="assignmentsCount"></param>
        /// <param name="issuesCount"></param>
        /// <param name="reviewsCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowsCounters(
            double tasksCount,
            double assignmentsCount,
            double issuesCount,
            double reviewsCount)
        {
            this.TasksCount = tasksCount;
            this.AssignmentsCount = assignmentsCount;
            this.IssuesCount = issuesCount;
            this.ReviewsCount = reviewsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowsCounters" /> class.
        /// </summary>
        public WorkflowsCounters()
        {
        }
    }
}