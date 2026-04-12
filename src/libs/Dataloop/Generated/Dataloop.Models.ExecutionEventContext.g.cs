
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionEventContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EventResourceTypeJsonConverter))]
        public global::Dataloop.EventResourceType? Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemStatusEvent")]
        public global::Dataloop.ItemStatusEvent? ItemStatusEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionEventContext" /> class.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="source"></param>
        /// <param name="action"></param>
        /// <param name="resourceId"></param>
        /// <param name="userId"></param>
        /// <param name="datasetId"></param>
        /// <param name="projectId"></param>
        /// <param name="body"></param>
        /// <param name="itemStatusEvent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionEventContext(
            global::Dataloop.EventResourceType? resource,
            string? source,
            string? action,
            string? resourceId,
            string? userId,
            string? datasetId,
            string? projectId,
            object? body,
            global::Dataloop.ItemStatusEvent? itemStatusEvent)
        {
            this.Resource = resource;
            this.Source = source;
            this.Action = action;
            this.ResourceId = resourceId;
            this.UserId = userId;
            this.DatasetId = datasetId;
            this.ProjectId = projectId;
            this.Body = body;
            this.ItemStatusEvent = itemStatusEvent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionEventContext" /> class.
        /// </summary>
        public ExecutionEventContext()
        {
        }
    }
}