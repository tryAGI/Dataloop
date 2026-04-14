
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommandStatusHistoryEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CommandStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CommandStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedExecution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool StartedExecution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedExecutionDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedExecutionDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandStatusHistoryEntry" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="date"></param>
        /// <param name="startedExecution"></param>
        /// <param name="startedExecutionDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommandStatusHistoryEntry(
            global::Dataloop.CommandStatus status,
            global::System.DateTime date,
            bool startedExecution,
            global::System.DateTime startedExecutionDate)
        {
            this.Status = status;
            this.Date = date;
            this.StartedExecution = startedExecution;
            this.StartedExecutionDate = startedExecutionDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandStatusHistoryEntry" /> class.
        /// </summary>
        public CommandStatusHistoryEntry()
        {
        }
    }
}