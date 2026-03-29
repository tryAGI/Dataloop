
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTaskItemScoresPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DeleteTaskItemScoresPayloadContext Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        public string? EntityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTaskItemScoresPayload" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="entityId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTaskItemScoresPayload(
            global::Dataloop.DeleteTaskItemScoresPayloadContext context,
            string? entityId)
        {
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.EntityId = entityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTaskItemScoresPayload" /> class.
        /// </summary>
        public DeleteTaskItemScoresPayload()
        {
        }
    }
}