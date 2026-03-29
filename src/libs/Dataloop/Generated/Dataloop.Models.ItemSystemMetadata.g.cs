
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ItemSystemMetadata
    {
        /// <summary>
        /// Original name of the item (usually the name of the file on the device it was uploaded from)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Originalname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimetype")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mimetype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Encoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskStatusLog")]
        public global::System.Collections.Generic.IList<global::Dataloop.ItemSystemMetadataTaskStatusLogItem>? TaskStatusLog { get; set; }

        /// <summary>
        /// References to other resources (i.e tasks, assignments, etc...)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refs")]
        public global::System.Collections.Generic.IList<global::Dataloop.ResourceReference>? Refs { get; set; }

        /// <summary>
        /// Determines if item content is textual of binary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBinary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBinary { get; set; }

        /// <summary>
        /// Thumbnail item id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnailId")]
        public string? ThumbnailId { get; set; }

        /// <summary>
        /// Thumbnail (with annotations embedded) item id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnailAnnotationsId")]
        public string? ThumbnailAnnotationsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemLinks")]
        public global::System.Collections.Generic.IList<global::Dataloop.ItemLink>? ItemLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::Dataloop.Modality>? Modalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemDatasetType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.SystemDatasetTypeJsonConverter))]
        public global::Dataloop.SystemDatasetType? SystemDatasetType { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationQueryThumbnailIdMap")]
        public global::Dataloop.RecordStringString? AnnotationQueryThumbnailIdMap { get; set; }

        /// <summary>
        /// Id of the parent it of this annotation thumbnail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationThumbnailParentId")]
        public string? AnnotationThumbnailParentId { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        public global::Dataloop.RecordCollectionKeysBoolean? Collections { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::Dataloop.RecordMLSplitListKeysBoolean? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSystemMetadata" /> class.
        /// </summary>
        /// <param name="originalname">
        /// Original name of the item (usually the name of the file on the device it was uploaded from)
        /// </param>
        /// <param name="mimetype"></param>
        /// <param name="size"></param>
        /// <param name="encoding"></param>
        /// <param name="isBinary">
        /// Determines if item content is textual of binary
        /// </param>
        /// <param name="taskStatusLog"></param>
        /// <param name="refs">
        /// References to other resources (i.e tasks, assignments, etc...)
        /// </param>
        /// <param name="thumbnailId">
        /// Thumbnail item id
        /// </param>
        /// <param name="thumbnailAnnotationsId">
        /// Thumbnail (with annotations embedded) item id
        /// </param>
        /// <param name="itemLinks"></param>
        /// <param name="modalities"></param>
        /// <param name="systemDatasetType"></param>
        /// <param name="annotationQueryThumbnailIdMap">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="annotationThumbnailParentId">
        /// Id of the parent it of this annotation thumbnail
        /// </param>
        /// <param name="collections">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="tags">
        /// Construct a type with a set of properties K of type T
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemSystemMetadata(
            string originalname,
            string mimetype,
            double size,
            string encoding,
            bool isBinary,
            global::System.Collections.Generic.IList<global::Dataloop.ItemSystemMetadataTaskStatusLogItem>? taskStatusLog,
            global::System.Collections.Generic.IList<global::Dataloop.ResourceReference>? refs,
            string? thumbnailId,
            string? thumbnailAnnotationsId,
            global::System.Collections.Generic.IList<global::Dataloop.ItemLink>? itemLinks,
            global::System.Collections.Generic.IList<global::Dataloop.Modality>? modalities,
            global::Dataloop.SystemDatasetType? systemDatasetType,
            global::Dataloop.RecordStringString? annotationQueryThumbnailIdMap,
            string? annotationThumbnailParentId,
            global::Dataloop.RecordCollectionKeysBoolean? collections,
            global::Dataloop.RecordMLSplitListKeysBoolean? tags)
        {
            this.Originalname = originalname ?? throw new global::System.ArgumentNullException(nameof(originalname));
            this.Mimetype = mimetype ?? throw new global::System.ArgumentNullException(nameof(mimetype));
            this.Size = size;
            this.Encoding = encoding ?? throw new global::System.ArgumentNullException(nameof(encoding));
            this.TaskStatusLog = taskStatusLog;
            this.Refs = refs;
            this.IsBinary = isBinary;
            this.ThumbnailId = thumbnailId;
            this.ThumbnailAnnotationsId = thumbnailAnnotationsId;
            this.ItemLinks = itemLinks;
            this.Modalities = modalities;
            this.SystemDatasetType = systemDatasetType;
            this.AnnotationQueryThumbnailIdMap = annotationQueryThumbnailIdMap;
            this.AnnotationThumbnailParentId = annotationThumbnailParentId;
            this.Collections = collections;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSystemMetadata" /> class.
        /// </summary>
        public ItemSystemMetadata()
        {
        }
    }
}