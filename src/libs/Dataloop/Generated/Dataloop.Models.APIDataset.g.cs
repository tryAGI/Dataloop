
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIDataset
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Annotated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryTree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DirectoryTree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.APIMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("readableType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReadableType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.APIDatasetAccessLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIDatasetAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Driver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readonly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Readonly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationOptions")]
        public global::Dataloop.ExpirationOptions? ExpirationOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexDriver")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.IndexDriverJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IndexDriver IndexDriver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableSyncWithCloned")]
        public bool? EnableSyncWithCloned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srcDataset")]
        public string? SrcDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AnnotationsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockProcessCommandId")]
        public string? LockProcessCommandId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastStorageSyncDate")]
        public global::System.DateTime? LastStorageSyncDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSyncing")]
        public bool? IsSyncing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIDataset" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="annotated"></param>
        /// <param name="itemsCount"></param>
        /// <param name="items"></param>
        /// <param name="directoryTree"></param>
        /// <param name="creator"></param>
        /// <param name="projects"></param>
        /// <param name="createdAt"></param>
        /// <param name="readableType"></param>
        /// <param name="accessLevel"></param>
        /// <param name="driver"></param>
        /// <param name="readonly"></param>
        /// <param name="indexDriver"></param>
        /// <param name="annotationsCount"></param>
        /// <param name="metadata"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="error"></param>
        /// <param name="expirationOptions"></param>
        /// <param name="enableSyncWithCloned"></param>
        /// <param name="srcDataset"></param>
        /// <param name="lockProcessCommandId"></param>
        /// <param name="lastStorageSyncDate"></param>
        /// <param name="isSyncing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIDataset(
            string id,
            string url,
            string name,
            double annotated,
            double itemsCount,
            string items,
            string directoryTree,
            string creator,
            global::System.Collections.Generic.IList<string> projects,
            global::System.DateTime createdAt,
            string readableType,
            global::Dataloop.APIDatasetAccessLevel accessLevel,
            string driver,
            bool @readonly,
            global::Dataloop.IndexDriver indexDriver,
            double annotationsCount,
            global::Dataloop.APIMetadata? metadata,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            object? error,
            global::Dataloop.ExpirationOptions? expirationOptions,
            bool? enableSyncWithCloned,
            string? srcDataset,
            string? lockProcessCommandId,
            global::System.DateTime? lastStorageSyncDate,
            bool? isSyncing)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Annotated = annotated;
            this.ItemsCount = itemsCount;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.DirectoryTree = directoryTree ?? throw new global::System.ArgumentNullException(nameof(directoryTree));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.ReadableType = readableType ?? throw new global::System.ArgumentNullException(nameof(readableType));
            this.AccessLevel = accessLevel;
            this.Driver = driver ?? throw new global::System.ArgumentNullException(nameof(driver));
            this.Readonly = @readonly;
            this.Error = error;
            this.ExpirationOptions = expirationOptions;
            this.IndexDriver = indexDriver;
            this.EnableSyncWithCloned = enableSyncWithCloned;
            this.SrcDataset = srcDataset;
            this.AnnotationsCount = annotationsCount;
            this.LockProcessCommandId = lockProcessCommandId;
            this.LastStorageSyncDate = lastStorageSyncDate;
            this.IsSyncing = isSyncing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIDataset" /> class.
        /// </summary>
        public APIDataset()
        {
        }
    }
}