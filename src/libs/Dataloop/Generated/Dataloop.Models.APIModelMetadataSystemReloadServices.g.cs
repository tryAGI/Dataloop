
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIModelMetadataSystemReloadServices
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commandId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommandId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModelMetadataSystemReloadServices" /> class.
        /// </summary>
        /// <param name="commandId"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIModelMetadataSystemReloadServices(
            string commandId,
            string? error)
        {
            this.Error = error;
            this.CommandId = commandId ?? throw new global::System.ArgumentNullException(nameof(commandId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModelMetadataSystemReloadServices" /> class.
        /// </summary>
        public APIModelMetadataSystemReloadServices()
        {
        }
    }
}