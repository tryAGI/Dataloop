
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIAnnotationEvent
    {
        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnnotationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        public global::Dataloop.PartialAPIAnnotation? Changes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIAnnotationEventDeleted?>))]
        public global::Dataloop.AnyOf<bool?, global::Dataloop.APIAnnotationEventDeleted?>? Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIAnnotationEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="annotationId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="user"></param>
        /// <param name="timestamp"></param>
        /// <param name="changes">
        /// Make all properties in T optional
        /// </param>
        /// <param name="deleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIAnnotationEvent(
            string id,
            string annotationId,
            string user,
            global::System.DateTime timestamp,
            global::Dataloop.PartialAPIAnnotation? changes,
            global::Dataloop.AnyOf<bool?, global::Dataloop.APIAnnotationEventDeleted?>? deleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AnnotationId = annotationId ?? throw new global::System.ArgumentNullException(nameof(annotationId));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Timestamp = timestamp;
            this.Changes = changes;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIAnnotationEvent" /> class.
        /// </summary>
        public APIAnnotationEvent()
        {
        }
    }
}