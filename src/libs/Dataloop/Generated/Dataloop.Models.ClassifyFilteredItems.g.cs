
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifyFilteredItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ClassifyFilteredItemsQuery Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ClassifyFilteredItemsAnnotation Annotation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyFilteredItems" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="annotation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyFilteredItems(
            global::Dataloop.ClassifyFilteredItemsQuery query,
            global::Dataloop.ClassifyFilteredItemsAnnotation annotation)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Annotation = annotation ?? throw new global::System.ArgumentNullException(nameof(annotation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyFilteredItems" /> class.
        /// </summary>
        public ClassifyFilteredItems()
        {
        }
    }
}