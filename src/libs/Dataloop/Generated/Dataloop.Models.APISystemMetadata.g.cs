
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APISystemMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APISystemMetadataSystem System { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APISystemMetadata" /> class.
        /// </summary>
        /// <param name="system"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APISystemMetadata(
            global::Dataloop.APISystemMetadataSystem system)
        {
            this.System = system ?? throw new global::System.ArgumentNullException(nameof(system));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APISystemMetadata" /> class.
        /// </summary>
        public APISystemMetadata()
        {
        }
    }
}