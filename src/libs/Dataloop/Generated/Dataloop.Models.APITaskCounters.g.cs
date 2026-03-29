
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APITaskCounters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeProjects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActiveProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeDatasets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActiveDatasets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeTasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActiveTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasksCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TasksCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APITaskCounters" /> class.
        /// </summary>
        /// <param name="activeProjects"></param>
        /// <param name="activeDatasets"></param>
        /// <param name="activeTasks"></param>
        /// <param name="tasksCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APITaskCounters(
            double activeProjects,
            double activeDatasets,
            double activeTasks,
            double tasksCount)
        {
            this.ActiveProjects = activeProjects;
            this.ActiveDatasets = activeDatasets;
            this.ActiveTasks = activeTasks;
            this.TasksCount = tasksCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APITaskCounters" /> class.
        /// </summary>
        public APITaskCounters()
        {
        }
    }
}