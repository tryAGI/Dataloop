
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentNotificationPayloadAgentInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicaId")]
        public string? ReplicaId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNotificationPayloadAgentInfo" /> class.
        /// </summary>
        /// <param name="replicaId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentNotificationPayloadAgentInfo(
            string? replicaId)
        {
            this.ReplicaId = replicaId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNotificationPayloadAgentInfo" /> class.
        /// </summary>
        public AgentNotificationPayloadAgentInfo()
        {
        }
    }
}