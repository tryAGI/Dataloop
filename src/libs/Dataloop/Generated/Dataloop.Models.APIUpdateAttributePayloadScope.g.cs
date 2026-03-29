
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIUpdateAttributePayloadScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labelIds")]
        public global::System.Collections.Generic.IList<string>? LabelIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtrees")]
        public global::System.Collections.Generic.IList<string>? Subtrees { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUpdateAttributePayloadScope" /> class.
        /// </summary>
        /// <param name="labelIds"></param>
        /// <param name="subtrees"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIUpdateAttributePayloadScope(
            global::System.Collections.Generic.IList<string>? labelIds,
            global::System.Collections.Generic.IList<string>? subtrees)
        {
            this.LabelIds = labelIds;
            this.Subtrees = subtrees;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUpdateAttributePayloadScope" /> class.
        /// </summary>
        public APIUpdateAttributePayloadScope()
        {
        }
    }
}