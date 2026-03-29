
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ItemMergeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceItemIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SourceItemIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemMergeRequest" /> class.
        /// </summary>
        /// <param name="sourceItemIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemMergeRequest(
            global::System.Collections.Generic.IList<string> sourceItemIds)
        {
            this.SourceItemIds = sourceItemIds ?? throw new global::System.ArgumentNullException(nameof(sourceItemIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemMergeRequest" /> class.
        /// </summary>
        public ItemMergeRequest()
        {
        }
    }
}