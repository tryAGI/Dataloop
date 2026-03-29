
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DpkAttributesDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.DpkAttributeValueDefinition> Values { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMultiple")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsMultiple { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DpkAttributesDefinition" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="values"></param>
        /// <param name="isMultiple"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DpkAttributesDefinition(
            string key,
            global::System.Collections.Generic.IList<global::Dataloop.DpkAttributeValueDefinition> values,
            bool isMultiple)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.IsMultiple = isMultiple;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpkAttributesDefinition" /> class.
        /// </summary>
        public DpkAttributesDefinition()
        {
        }
    }
}