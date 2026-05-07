
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceAuditLog
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ctx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ResourceAuditLogCtx Ctx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ResourceAuditEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ResourceAuditEventType EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityName")]
        public string? EntityName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAuditLog" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <param name="ctx"></param>
        /// <param name="user"></param>
        /// <param name="entityType"></param>
        /// <param name="eventType"></param>
        /// <param name="entityId"></param>
        /// <param name="entityName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceAuditLog(
            string id,
            global::System.DateTime time,
            global::Dataloop.ResourceAuditLogCtx ctx,
            string user,
            string entityType,
            global::Dataloop.ResourceAuditEventType eventType,
            string entityId,
            string? entityName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Time = time;
            this.Ctx = ctx ?? throw new global::System.ArgumentNullException(nameof(ctx));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.EntityType = entityType ?? throw new global::System.ArgumentNullException(nameof(entityType));
            this.EventType = eventType;
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.EntityName = entityName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAuditLog" /> class.
        /// </summary>
        public ResourceAuditLog()
        {
        }
    }
}