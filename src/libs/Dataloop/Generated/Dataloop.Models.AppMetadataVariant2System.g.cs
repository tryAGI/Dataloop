
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppMetadataVariant2System
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commands")]
        public global::Dataloop.AppCommandsReference? Commands { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppMetadataVariant2System" /> class.
        /// </summary>
        /// <param name="commands"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppMetadataVariant2System(
            global::Dataloop.AppCommandsReference? commands)
        {
            this.Commands = commands;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppMetadataVariant2System" /> class.
        /// </summary>
        public AppMetadataVariant2System()
        {
        }
    }
}