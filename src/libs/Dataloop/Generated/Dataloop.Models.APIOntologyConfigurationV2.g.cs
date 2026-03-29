
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIOntologyConfigurationV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.APIMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIOntologyConfigurationV2" /> class.
        /// </summary>
        /// <param name="creator"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIOntologyConfigurationV2(
            string? creator,
            global::Dataloop.APIMetadata? metadata)
        {
            this.Creator = creator;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIOntologyConfigurationV2" /> class.
        /// </summary>
        public APIOntologyConfigurationV2()
        {
        }
    }
}