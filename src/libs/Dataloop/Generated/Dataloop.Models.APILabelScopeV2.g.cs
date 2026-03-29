
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APILabelScopeV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtrees")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Subtrees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labelIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> LabelIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APILabelScopeV2" /> class.
        /// </summary>
        /// <param name="subtrees"></param>
        /// <param name="labelIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APILabelScopeV2(
            global::System.Collections.Generic.IList<string> subtrees,
            global::System.Collections.Generic.IList<string> labelIds)
        {
            this.Subtrees = subtrees ?? throw new global::System.ArgumentNullException(nameof(subtrees));
            this.LabelIds = labelIds ?? throw new global::System.ArgumentNullException(nameof(labelIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APILabelScopeV2" /> class.
        /// </summary>
        public APILabelScopeV2()
        {
        }
    }
}