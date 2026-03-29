
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialItemMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public global::Dataloop.ItemSystemMetadata? System { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialItemMetadata" /> class.
        /// </summary>
        /// <param name="system"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialItemMetadata(
            global::Dataloop.ItemSystemMetadata? system)
        {
            this.System = system;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialItemMetadata" /> class.
        /// </summary>
        public PartialItemMetadata()
        {
        }
    }
}