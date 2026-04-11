
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DpkAttributeValueDefinitionIcon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("light")]
        public string? Light { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dark")]
        public string? Dark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DpkAttributeValueDefinitionIcon" /> class.
        /// </summary>
        /// <param name="light"></param>
        /// <param name="dark"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DpkAttributeValueDefinitionIcon(
            string? light,
            string? dark)
        {
            this.Light = light;
            this.Dark = dark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpkAttributeValueDefinitionIcon" /> class.
        /// </summary>
        public DpkAttributeValueDefinitionIcon()
        {
        }
    }
}