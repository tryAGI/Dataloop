
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentNotificationPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationName")]
        public string? NotificationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationPath")]
        public string? NotificationPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentInfo")]
        public global::Dataloop.AgentNotificationPayloadAgentInfo? AgentInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNotificationPayload" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="message"></param>
        /// <param name="notificationName"></param>
        /// <param name="notificationPath"></param>
        /// <param name="agentInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentNotificationPayload(
            string action,
            string? message,
            string? notificationName,
            string? notificationPath,
            global::Dataloop.AgentNotificationPayloadAgentInfo? agentInfo)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Message = message;
            this.NotificationName = notificationName;
            this.NotificationPath = notificationPath;
            this.AgentInfo = agentInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNotificationPayload" /> class.
        /// </summary>
        public AgentNotificationPayload()
        {
        }
    }
}