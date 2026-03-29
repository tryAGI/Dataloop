
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvalidateAnnotationThumbnailsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsQuery")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DQLResourceQuery ItemsQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidateAnnotationThumbnailsRequest" /> class.
        /// </summary>
        /// <param name="itemsQuery"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvalidateAnnotationThumbnailsRequest(
            global::Dataloop.DQLResourceQuery itemsQuery)
        {
            this.ItemsQuery = itemsQuery ?? throw new global::System.ArgumentNullException(nameof(itemsQuery));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidateAnnotationThumbnailsRequest" /> class.
        /// </summary>
        public InvalidateAnnotationThumbnailsRequest()
        {
        }
    }
}