
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommandError
    {
        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stack")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandError" /> class.
        /// </summary>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="message"></param>
        /// <param name="stack"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommandError(
            string id,
            string message,
            string stack,
            string? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Stack = stack ?? throw new global::System.ArgumentNullException(nameof(stack));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandError" /> class.
        /// </summary>
        public CommandError()
        {
        }
    }
}