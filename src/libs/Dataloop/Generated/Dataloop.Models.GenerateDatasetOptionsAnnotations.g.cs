
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateDatasetOptionsAnnotations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.GenerateDatasetOptionsAnnotationsMetadata? Metadata { get; set; }

        /// <summary>
        /// number of distinct labels in dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationsAttributesOptionsCount")]
        public double? AnnotationsAttributesOptionsCount { get; set; }

        /// <summary>
        /// how many annotations per item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countPerItem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CountPerItem { get; set; }

        /// <summary>
        /// which annotation types should be generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>> Types { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDatasetOptionsAnnotations" /> class.
        /// </summary>
        /// <param name="labels">
        /// number of distinct labels in dataset
        /// </param>
        /// <param name="countPerItem">
        /// how many annotations per item
        /// </param>
        /// <param name="types">
        /// which annotation types should be generated
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="annotationsAttributesOptionsCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateDatasetOptionsAnnotations(
            double labels,
            double countPerItem,
            global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>> types,
            global::Dataloop.GenerateDatasetOptionsAnnotationsMetadata? metadata,
            double? annotationsAttributesOptionsCount)
        {
            this.Metadata = metadata;
            this.Labels = labels;
            this.AnnotationsAttributesOptionsCount = annotationsAttributesOptionsCount;
            this.CountPerItem = countPerItem;
            this.Types = types ?? throw new global::System.ArgumentNullException(nameof(types));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDatasetOptionsAnnotations" /> class.
        /// </summary>
        public GenerateDatasetOptionsAnnotations()
        {
        }
    }
}