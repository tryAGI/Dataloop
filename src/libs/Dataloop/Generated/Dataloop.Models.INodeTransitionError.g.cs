
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class INodeTransitionError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceNodeName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNodeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceNodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetNodeName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNodeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetNodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayMessage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="INodeTransitionError" /> class.
        /// </summary>
        /// <param name="sourceNodeName"></param>
        /// <param name="sourceNodeId"></param>
        /// <param name="targetNodeName"></param>
        /// <param name="targetNodeId"></param>
        /// <param name="error"></param>
        /// <param name="displayMessage"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public INodeTransitionError(
            string sourceNodeName,
            string sourceNodeId,
            string targetNodeName,
            string targetNodeId,
            object error,
            string displayMessage,
            string? message)
        {
            this.SourceNodeName = sourceNodeName ?? throw new global::System.ArgumentNullException(nameof(sourceNodeName));
            this.SourceNodeId = sourceNodeId ?? throw new global::System.ArgumentNullException(nameof(sourceNodeId));
            this.TargetNodeName = targetNodeName ?? throw new global::System.ArgumentNullException(nameof(targetNodeName));
            this.TargetNodeId = targetNodeId ?? throw new global::System.ArgumentNullException(nameof(targetNodeId));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.DisplayMessage = displayMessage ?? throw new global::System.ArgumentNullException(nameof(displayMessage));
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="INodeTransitionError" /> class.
        /// </summary>
        public INodeTransitionError()
        {
        }
    }
}