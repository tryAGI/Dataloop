
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CoordinatesNote
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.NoteMessage> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asignee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Asignee { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinatesNote" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="status"></param>
        /// <param name="createTime"></param>
        /// <param name="creator"></param>
        /// <param name="asignee"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoordinatesNote(
            global::System.Collections.Generic.IList<global::Dataloop.NoteMessage> messages,
            string status,
            double createTime,
            string creator,
            string asignee)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreateTime = createTime;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Asignee = asignee ?? throw new global::System.ArgumentNullException(nameof(asignee));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinatesNote" /> class.
        /// </summary>
        public CoordinatesNote()
        {
        }
    }
}