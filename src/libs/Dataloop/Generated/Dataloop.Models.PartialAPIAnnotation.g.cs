
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialAPIAnnotation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnnotationTypeJsonConverter))]
        public global::Dataloop.AnnotationType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<string>? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.APIAnnotationCoordinateTypesJsonConverter))]
        public global::Dataloop.APIAnnotationCoordinateTypes? Coordinates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.Dictionary? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public string? Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        public string? Dataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labelSuggestions")]
        public global::System.Collections.Generic.Dictionary<string, double>? LabelSuggestions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.RequestSourceJsonConverter))]
        public global::Dataloop.RequestSource? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srcAnnotation")]
        public string? SrcAnnotation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAPIAnnotation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="type"></param>
        /// <param name="label"></param>
        /// <param name="attributes"></param>
        /// <param name="coordinates"></param>
        /// <param name="metadata"></param>
        /// <param name="creator"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="itemId"></param>
        /// <param name="item"></param>
        /// <param name="datasetId"></param>
        /// <param name="dataset"></param>
        /// <param name="hash"></param>
        /// <param name="labelSuggestions"></param>
        /// <param name="source"></param>
        /// <param name="description"></param>
        /// <param name="srcAnnotation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialAPIAnnotation(
            string? id,
            string? url,
            global::Dataloop.AnnotationType? type,
            string? label,
            global::System.Collections.Generic.IList<string>? attributes,
            global::Dataloop.APIAnnotationCoordinateTypes? coordinates,
            global::Dataloop.Dictionary? metadata,
            string? creator,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            string? itemId,
            string? item,
            string? datasetId,
            string? dataset,
            string? hash,
            global::System.Collections.Generic.Dictionary<string, double>? labelSuggestions,
            global::Dataloop.RequestSource? source,
            string? description,
            string? srcAnnotation)
        {
            this.Id = id;
            this.Url = url;
            this.Type = type;
            this.Label = label;
            this.Attributes = attributes;
            this.Coordinates = coordinates;
            this.Metadata = metadata;
            this.Creator = creator;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.ItemId = itemId;
            this.Item = item;
            this.DatasetId = datasetId;
            this.Dataset = dataset;
            this.Hash = hash;
            this.LabelSuggestions = labelSuggestions;
            this.Source = source;
            this.Description = description;
            this.SrcAnnotation = srcAnnotation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAPIAnnotation" /> class.
        /// </summary>
        public PartialAPIAnnotation()
        {
        }
    }
}