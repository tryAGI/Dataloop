
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICompositionError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayMessage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ICompositionErrorContext Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("support")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Support { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <param name="displayMessage"></param>
        /// <param name="context"></param>
        /// <param name="support"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICompositionError(
            string code,
            string type,
            string message,
            string displayMessage,
            global::Dataloop.ICompositionErrorContext context,
            string support)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DisplayMessage = displayMessage ?? throw new global::System.ArgumentNullException(nameof(displayMessage));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.Support = support ?? throw new global::System.ArgumentNullException(nameof(support));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionError" /> class.
        /// </summary>
        public ICompositionError()
        {
        }
    }
}