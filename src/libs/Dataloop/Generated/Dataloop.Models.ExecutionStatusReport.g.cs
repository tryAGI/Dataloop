
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionStatusReport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ExecutionStatusNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ExecutionStatusName Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentComplete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PercentComplete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Dataloop.Dictionary? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Dataloop.Dictionary? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicaId")]
        public string? ReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicaType")]
        public string? ReplicaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipUpdate")]
        public bool? SkipUpdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hookResolved")]
        public bool? HookResolved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionStatusReport" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="percentComplete"></param>
        /// <param name="error"></param>
        /// <param name="output"></param>
        /// <param name="action"></param>
        /// <param name="replicaId"></param>
        /// <param name="replicaType"></param>
        /// <param name="skipUpdate"></param>
        /// <param name="hookResolved"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionStatusReport(
            global::System.DateTime timestamp,
            global::Dataloop.ExecutionStatusName status,
            string message,
            double percentComplete,
            global::Dataloop.Dictionary? error,
            global::Dataloop.Dictionary? output,
            string? action,
            string? replicaId,
            string? replicaType,
            bool? skipUpdate,
            bool? hookResolved)
        {
            this.Timestamp = timestamp;
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.PercentComplete = percentComplete;
            this.Error = error;
            this.Output = output;
            this.Action = action;
            this.ReplicaId = replicaId;
            this.ReplicaType = replicaType;
            this.SkipUpdate = skipUpdate;
            this.HookResolved = hookResolved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionStatusReport" /> class.
        /// </summary>
        public ExecutionStatusReport()
        {
        }
    }
}