
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIDatasetFileItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dir")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dir { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.APIDatasetFileItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIDatasetFileItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ItemSpecTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ItemSpecType Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Hidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APISystemMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signedStream")]
        public string? SignedStream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AnnotationsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<bool?, global::Dataloop.APIDatasetFileItemAnnotated?> Annotated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thumbnail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srcItem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SrcItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srcDataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SrcDataset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIDatasetFileItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="datasetId"></param>
        /// <param name="dir"></param>
        /// <param name="filename"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="spec"></param>
        /// <param name="hidden"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAt"></param>
        /// <param name="dataset"></param>
        /// <param name="creator"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="annotationsCount"></param>
        /// <param name="annotated"></param>
        /// <param name="stream"></param>
        /// <param name="thumbnail"></param>
        /// <param name="annotations"></param>
        /// <param name="srcItem"></param>
        /// <param name="srcDataset"></param>
        /// <param name="description"></param>
        /// <param name="signedStream"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIDatasetFileItem(
            string id,
            string url,
            string datasetId,
            string dir,
            string filename,
            string name,
            global::Dataloop.APIDatasetFileItemType type,
            global::Dataloop.ItemSpecType spec,
            bool hidden,
            global::Dataloop.APISystemMetadata metadata,
            global::System.DateTime createdAt,
            string dataset,
            string creator,
            global::System.DateTime updatedAt,
            string updatedBy,
            double annotationsCount,
            global::Dataloop.AnyOf<bool?, global::Dataloop.APIDatasetFileItemAnnotated?> annotated,
            string stream,
            string thumbnail,
            string annotations,
            string srcItem,
            string srcDataset,
            string? description,
            string? signedStream)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.Dir = dir ?? throw new global::System.ArgumentNullException(nameof(dir));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Spec = spec;
            this.Hidden = hidden;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedAt = createdAt;
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Description = description;
            this.SignedStream = signedStream;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy ?? throw new global::System.ArgumentNullException(nameof(updatedBy));
            this.AnnotationsCount = annotationsCount;
            this.Annotated = annotated;
            this.Stream = stream ?? throw new global::System.ArgumentNullException(nameof(stream));
            this.Thumbnail = thumbnail ?? throw new global::System.ArgumentNullException(nameof(thumbnail));
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
            this.SrcItem = srcItem ?? throw new global::System.ArgumentNullException(nameof(srcItem));
            this.SrcDataset = srcDataset ?? throw new global::System.ArgumentNullException(nameof(srcDataset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIDatasetFileItem" /> class.
        /// </summary>
        public APIDatasetFileItem()
        {
        }
    }
}