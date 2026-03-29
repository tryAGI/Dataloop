
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// currently datasets have only 1 project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Driver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DatasetMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Type { get; set; }

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
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// lastStorageSyncDate points to the time when storage was last synced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastStorageSyncDate")]
        public global::System.DateTime? LastStorageSyncDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DatasetAccessLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DatasetAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Count all 'file' type items in dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemsCount { get; set; }

        /// <summary>
        /// Count all items that has annotations in the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotatedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AnnotatedCount { get; set; }

        /// <summary>
        /// Count the number of annotations In the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AnnotationsCount { get; set; }

        /// <summary>
        /// Determines if this dataset is indexed to elasticsearch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_indexed")]
        public bool? Indexed { get; set; }

        /// <summary>
        /// Determines if this dataset is marked for deletion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_markForDeletion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MarkForDeletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletionInformation")]
        public global::Dataloop.DatasetDeletionInformation? DeletionInformation { get; set; }

        /// <summary>
        /// Determines if this dataset is in readonly mode and cannot be modified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readonly")]
        public bool? Readonly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationOptions")]
        public global::Dataloop.ExpirationOptions? ExpirationOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authz")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AuthZBlockDatasetContext Authz { get; set; }

        /// <summary>
        /// determines status of S2 sync for this dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_syncStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DatasetSyncStatusJsonConverter))]
        public global::Dataloop.DatasetSyncStatus? SyncStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexDriver")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DatasetIndexDriversJsonConverter))]
        public global::Dataloop.DatasetIndexDrivers? IndexDriver { get; set; }

        /// <summary>
        /// Flag that determines if it is allowed to sync the specified dataset if it is
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableSyncWithCloned")]
        public bool? EnableSyncWithCloned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DatasetSchemaMap Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::Dataloop.S2ItemMetadataSchema? Schema2 { get; set; }

        /// <summary>
        /// Determines when the items in the dataset were last udpate of deleted. This flag is used in the SchemaCleanup command
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemaCleanupDate")]
        public global::System.DateTime? SchemaCleanupDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockProcessCommandId")]
        public string? LockProcessCommandId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <param name="projects">
        /// currently datasets have only 1 project
        /// </param>
        /// <param name="driver"></param>
        /// <param name="metadata"></param>
        /// <param name="type"></param>
        /// <param name="readableType"></param>
        /// <param name="accessLevel"></param>
        /// <param name="itemsCount">
        /// Count all 'file' type items in dataset
        /// </param>
        /// <param name="annotatedCount">
        /// Count all items that has annotations in the dataset
        /// </param>
        /// <param name="annotationsCount">
        /// Count the number of annotations In the dataset
        /// </param>
        /// <param name="markForDeletion">
        /// Determines if this dataset is marked for deletion
        /// </param>
        /// <param name="authz"></param>
        /// <param name="schema"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastStorageSyncDate">
        /// lastStorageSyncDate points to the time when storage was last synced
        /// </param>
        /// <param name="updatedBy"></param>
        /// <param name="indexed">
        /// Determines if this dataset is indexed to elasticsearch
        /// </param>
        /// <param name="deletionInformation"></param>
        /// <param name="readonly">
        /// Determines if this dataset is in readonly mode and cannot be modified
        /// </param>
        /// <param name="expirationOptions"></param>
        /// <param name="syncStatus">
        /// determines status of S2 sync for this dataset
        /// </param>
        /// <param name="indexDriver"></param>
        /// <param name="enableSyncWithCloned">
        /// Flag that determines if it is allowed to sync the specified dataset if it is
        /// </param>
        /// <param name="schema2"></param>
        /// <param name="schemaCleanupDate">
        /// Determines when the items in the dataset were last udpate of deleted. This flag is used in the SchemaCleanup command
        /// </param>
        /// <param name="lockProcessCommandId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Dataset(
            string id,
            string name,
            string creator,
            global::System.Collections.Generic.IList<string> projects,
            string driver,
            global::Dataloop.DatasetMetadata metadata,
            double type,
            string readableType,
            global::Dataloop.DatasetAccessLevel accessLevel,
            double itemsCount,
            double annotatedCount,
            double annotationsCount,
            bool markForDeletion,
            global::Dataloop.AuthZBlockDatasetContext authz,
            global::Dataloop.DatasetSchemaMap schema,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? lastStorageSyncDate,
            string? updatedBy,
            bool? indexed,
            global::Dataloop.DatasetDeletionInformation? deletionInformation,
            bool? @readonly,
            global::Dataloop.ExpirationOptions? expirationOptions,
            global::Dataloop.DatasetSyncStatus? syncStatus,
            global::Dataloop.DatasetIndexDrivers? indexDriver,
            bool? enableSyncWithCloned,
            global::Dataloop.S2ItemMetadataSchema? schema2,
            global::System.DateTime? schemaCleanupDate,
            string? lockProcessCommandId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Driver = driver;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Type = type;
            this.ReadableType = readableType ?? throw new global::System.ArgumentNullException(nameof(readableType));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastStorageSyncDate = lastStorageSyncDate;
            this.UpdatedBy = updatedBy;
            this.AccessLevel = accessLevel;
            this.ItemsCount = itemsCount;
            this.AnnotatedCount = annotatedCount;
            this.AnnotationsCount = annotationsCount;
            this.Indexed = indexed;
            this.MarkForDeletion = markForDeletion;
            this.DeletionInformation = deletionInformation;
            this.Readonly = @readonly;
            this.ExpirationOptions = expirationOptions;
            this.Authz = authz ?? throw new global::System.ArgumentNullException(nameof(authz));
            this.SyncStatus = syncStatus;
            this.IndexDriver = indexDriver;
            this.EnableSyncWithCloned = enableSyncWithCloned;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Schema2 = schema2;
            this.SchemaCleanupDate = schemaCleanupDate;
            this.LockProcessCommandId = lockProcessCommandId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}