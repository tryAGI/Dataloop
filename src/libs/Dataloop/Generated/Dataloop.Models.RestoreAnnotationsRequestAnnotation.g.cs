
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RestoreAnnotationsRequestAnnotation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnnotationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAnnotationsRequestAnnotation" /> class.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="annotationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestoreAnnotationsRequestAnnotation(
            string itemId,
            string annotationId)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.AnnotationId = annotationId ?? throw new global::System.ArgumentNullException(nameof(annotationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAnnotationsRequestAnnotation" /> class.
        /// </summary>
        public RestoreAnnotationsRequestAnnotation()
        {
        }
    }
}