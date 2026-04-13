
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APITrigger
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.TriggerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.TriggerType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.EntityReferenceMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APITrigger" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="type"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="active"></param>
        /// <param name="metadata"></param>
        /// <param name="updatedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APITrigger(
            string id,
            string url,
            global::Dataloop.TriggerType type,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string creator,
            string name,
            string projectId,
            bool active,
            global::Dataloop.EntityReferenceMetadata? metadata,
            string? updatedBy)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Active = active;
            this.Metadata = metadata;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APITrigger" /> class.
        /// </summary>
        public APITrigger()
        {
        }
    }
}