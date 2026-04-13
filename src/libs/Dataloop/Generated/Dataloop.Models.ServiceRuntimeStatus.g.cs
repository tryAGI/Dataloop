
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceRuntimeStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicaId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ReplicaReasonJsonConverter))]
        public global::Dataloop.ReplicaReason? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restartCount")]
        public double? RestartCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRestartTime")]
        public global::System.DateTime? LastRestartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRuntimeStatus" /> class.
        /// </summary>
        /// <param name="replicaId"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="reason"></param>
        /// <param name="message"></param>
        /// <param name="restartCount"></param>
        /// <param name="lastRestartTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceRuntimeStatus(
            string replicaId,
            bool status,
            global::System.DateTime? createdAt,
            global::Dataloop.ReplicaReason? reason,
            string? message,
            double? restartCount,
            global::System.DateTime? lastRestartTime)
        {
            this.ReplicaId = replicaId ?? throw new global::System.ArgumentNullException(nameof(replicaId));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.Reason = reason;
            this.Message = message;
            this.RestartCount = restartCount;
            this.LastRestartTime = lastRestartTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRuntimeStatus" /> class.
        /// </summary>
        public ServiceRuntimeStatus()
        {
        }
    }
}