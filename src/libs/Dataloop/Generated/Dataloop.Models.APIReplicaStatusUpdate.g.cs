
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIReplicaStatusUpdate
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ReplicaStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ReplicaStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numRestarts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumRestarts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uptime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Uptime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIReplicaStatusUpdate" /> class.
        /// </summary>
        /// <param name="replicaId"></param>
        /// <param name="status"></param>
        /// <param name="numRestarts"></param>
        /// <param name="uptime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIReplicaStatusUpdate(
            string replicaId,
            global::Dataloop.ReplicaStatus status,
            double numRestarts,
            double uptime)
        {
            this.ReplicaId = replicaId ?? throw new global::System.ArgumentNullException(nameof(replicaId));
            this.Status = status;
            this.NumRestarts = numRestarts;
            this.Uptime = uptime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIReplicaStatusUpdate" /> class.
        /// </summary>
        public APIReplicaStatusUpdate()
        {
        }
    }
}