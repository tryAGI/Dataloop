
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BullkGenerateAnnotationThumbnailsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.BullkGenerateAnnotationThumbnailsRequestOptions Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationsQuery")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DQLResourceQuery AnnotationsQuery { get; set; }

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
        /// Initializes a new instance of the <see cref="BullkGenerateAnnotationThumbnailsRequest" /> class.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="annotationsQuery"></param>
        /// <param name="itemsQuery"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BullkGenerateAnnotationThumbnailsRequest(
            global::Dataloop.BullkGenerateAnnotationThumbnailsRequestOptions options,
            global::Dataloop.DQLResourceQuery annotationsQuery,
            global::Dataloop.DQLResourceQuery itemsQuery)
        {
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.AnnotationsQuery = annotationsQuery ?? throw new global::System.ArgumentNullException(nameof(annotationsQuery));
            this.ItemsQuery = itemsQuery ?? throw new global::System.ArgumentNullException(nameof(itemsQuery));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BullkGenerateAnnotationThumbnailsRequest" /> class.
        /// </summary>
        public BullkGenerateAnnotationThumbnailsRequest()
        {
        }
    }
}