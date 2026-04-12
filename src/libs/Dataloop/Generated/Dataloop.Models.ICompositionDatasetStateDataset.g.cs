
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICompositionDatasetStateDataset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexDriver")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetIndexDriverJsonConverter))]
        public global::Dataloop.ICompositionDatasetStateDatasetIndexDriver? IndexDriver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Driver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shareLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetShareLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ICompositionDatasetStateDatasetShareLevel ShareLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readableType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReadableType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxClientObjectId")]
        public double? MaxClientObjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientObjectId")]
        public double? ClientObjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ICompositionDatasetStateDatasetExport Export { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryTree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DirectoryTree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Classes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Annotated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.ICompositionDatasetStateDatasetAnnotation> Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionDatasetStateDataset" /> class.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="shareLevel"></param>
        /// <param name="readableType"></param>
        /// <param name="createdAt"></param>
        /// <param name="export"></param>
        /// <param name="projects"></param>
        /// <param name="creator"></param>
        /// <param name="directoryTree"></param>
        /// <param name="items"></param>
        /// <param name="url"></param>
        /// <param name="itemsCount"></param>
        /// <param name="attributes"></param>
        /// <param name="classes"></param>
        /// <param name="annotated"></param>
        /// <param name="annotations"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="indexDriver"></param>
        /// <param name="error"></param>
        /// <param name="maxClientObjectId"></param>
        /// <param name="clientObjectId"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICompositionDatasetStateDataset(
            string driver,
            global::Dataloop.ICompositionDatasetStateDatasetShareLevel shareLevel,
            string readableType,
            global::System.DateTime createdAt,
            global::Dataloop.ICompositionDatasetStateDatasetExport export,
            global::System.Collections.Generic.IList<string> projects,
            string creator,
            string directoryTree,
            string items,
            string url,
            double itemsCount,
            global::System.Collections.Generic.IList<string> attributes,
            global::System.Collections.Generic.Dictionary<string, string> classes,
            double annotated,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionDatasetStateDatasetAnnotation> annotations,
            string name,
            string id,
            global::Dataloop.ICompositionDatasetStateDatasetIndexDriver? indexDriver,
            object? error,
            double? maxClientObjectId,
            double? clientObjectId,
            object? metadata)
        {
            this.IndexDriver = indexDriver;
            this.Error = error;
            this.Driver = driver ?? throw new global::System.ArgumentNullException(nameof(driver));
            this.ShareLevel = shareLevel;
            this.ReadableType = readableType ?? throw new global::System.ArgumentNullException(nameof(readableType));
            this.CreatedAt = createdAt;
            this.MaxClientObjectId = maxClientObjectId;
            this.ClientObjectId = clientObjectId;
            this.Metadata = metadata;
            this.Export = export ?? throw new global::System.ArgumentNullException(nameof(export));
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.DirectoryTree = directoryTree ?? throw new global::System.ArgumentNullException(nameof(directoryTree));
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ItemsCount = itemsCount;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Classes = classes ?? throw new global::System.ArgumentNullException(nameof(classes));
            this.Annotated = annotated;
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionDatasetStateDataset" /> class.
        /// </summary>
        public ICompositionDatasetStateDataset()
        {
        }
    }
}