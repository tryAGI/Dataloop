
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IExecutionStatistics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgTimePerExecution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgTimePerExecution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgExecutionsPerDay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgExecutionsPerDay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IExecutionStatistics" /> class.
        /// </summary>
        /// <param name="avgTimePerExecution"></param>
        /// <param name="avgExecutionsPerDay"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IExecutionStatistics(
            double avgTimePerExecution,
            double avgExecutionsPerDay)
        {
            this.AvgTimePerExecution = avgTimePerExecution;
            this.AvgExecutionsPerDay = avgExecutionsPerDay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IExecutionStatistics" /> class.
        /// </summary>
        public IExecutionStatistics()
        {
        }
    }
}