
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIDpk Dpk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="dpk"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResponse(
            string message,
            global::Dataloop.APIDpk dpk)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Dpk = dpk ?? throw new global::System.ArgumentNullException(nameof(dpk));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResponse" /> class.
        /// </summary>
        public UpdateResponse()
        {
        }
    }
}