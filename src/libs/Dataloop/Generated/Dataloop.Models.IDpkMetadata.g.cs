
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public global::Dataloop.SystemRefs? System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commands")]
        public global::Dataloop.IDpkMetadataCommands? Commands { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkMetadata" /> class.
        /// </summary>
        /// <param name="system"></param>
        /// <param name="commands"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkMetadata(
            global::Dataloop.SystemRefs? system,
            global::Dataloop.IDpkMetadataCommands? commands)
        {
            this.System = system;
            this.Commands = commands;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkMetadata" /> class.
        /// </summary>
        public IDpkMetadata()
        {
        }
    }
}