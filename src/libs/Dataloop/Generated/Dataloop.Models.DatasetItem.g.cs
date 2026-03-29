
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetItem
    {
        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StorageId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("filename_collated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilenameCollated { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DatasetItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DatasetItemType Type { get; set; }

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
        public required global::Dataloop.ItemMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Annotated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revisions")]
        public global::System.Collections.Generic.IList<global::Dataloop.ItemRevision>? Revisions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.MasterItemSpec, global::Dataloop.ClonedItemSpec>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::Dataloop.MasterItemSpec, global::Dataloop.ClonedItemSpec> Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotationsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AnnotationsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discardedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DiscardedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authz")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AuthZBlockItemContext Authz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// item version - monotonic, integer, increased every item update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Version { get; set; }

        /// <summary>
        /// "updatedAt" is a timestamp indicating the most recent modification date of an item.<br/>
        ///  doesn’t get updated on counter inc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// "updatedBy" refers to the identifier of the user who made the most recent update to an item.<br/>
        ///  doesn’t get updated on counter inc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedBy { get; set; }

        /// <summary>
        /// "annotatedAt" is a timestamp indicating the most recent modification(add / update / delete) in the annotations of an item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotatedAt")]
        public global::System.DateTime? AnnotatedAt { get; set; }

        /// <summary>
        /// Item description - free text field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Flags if the item has a description - here for mongo search and indexing purposes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("described")]
        public bool? Described { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refsMap")]
        public global::Dataloop.RecordStringResourceReference? RefsMap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItem" /> class.
        /// </summary>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="datasetId"></param>
        /// <param name="storageId"></param>
        /// <param name="dir"></param>
        /// <param name="filename"></param>
        /// <param name="filenameCollated"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="hidden"></param>
        /// <param name="metadata"></param>
        /// <param name="annotated"></param>
        /// <param name="spec"></param>
        /// <param name="annotationsCount"></param>
        /// <param name="discardedCount"></param>
        /// <param name="authz"></param>
        /// <param name="creator"></param>
        /// <param name="version">
        /// item version - monotonic, integer, increased every item update
        /// </param>
        /// <param name="updatedAt">
        /// "updatedAt" is a timestamp indicating the most recent modification date of an item.<br/>
        ///  doesn’t get updated on counter inc.
        /// </param>
        /// <param name="updatedBy">
        /// "updatedBy" refers to the identifier of the user who made the most recent update to an item.<br/>
        ///  doesn’t get updated on counter inc
        /// </param>
        /// <param name="revisions"></param>
        /// <param name="annotatedAt">
        /// "annotatedAt" is a timestamp indicating the most recent modification(add / update / delete) in the annotations of an item.
        /// </param>
        /// <param name="description">
        /// Item description - free text field
        /// </param>
        /// <param name="described">
        /// Flags if the item has a description - here for mongo search and indexing purposes
        /// </param>
        /// <param name="refsMap">
        /// Construct a type with a set of properties K of type T
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetItem(
            string id,
            global::System.DateTime createdAt,
            string datasetId,
            string storageId,
            string dir,
            string filename,
            string filenameCollated,
            string name,
            global::Dataloop.DatasetItemType type,
            bool hidden,
            global::Dataloop.ItemMetadata metadata,
            bool annotated,
            global::Dataloop.AnyOf<global::Dataloop.MasterItemSpec, global::Dataloop.ClonedItemSpec> spec,
            double annotationsCount,
            double discardedCount,
            global::Dataloop.AuthZBlockItemContext authz,
            string creator,
            double version,
            global::System.DateTime updatedAt,
            string updatedBy,
            global::System.Collections.Generic.IList<global::Dataloop.ItemRevision>? revisions,
            global::System.DateTime? annotatedAt,
            string? description,
            bool? described,
            global::Dataloop.RecordStringResourceReference? refsMap)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.StorageId = storageId ?? throw new global::System.ArgumentNullException(nameof(storageId));
            this.Dir = dir ?? throw new global::System.ArgumentNullException(nameof(dir));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.FilenameCollated = filenameCollated ?? throw new global::System.ArgumentNullException(nameof(filenameCollated));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Hidden = hidden;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Annotated = annotated;
            this.Revisions = revisions;
            this.Spec = spec;
            this.AnnotationsCount = annotationsCount;
            this.DiscardedCount = discardedCount;
            this.Authz = authz ?? throw new global::System.ArgumentNullException(nameof(authz));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Version = version;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy ?? throw new global::System.ArgumentNullException(nameof(updatedBy));
            this.AnnotatedAt = annotatedAt;
            this.Description = description;
            this.Described = described;
            this.RefsMap = refsMap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItem" /> class.
        /// </summary>
        public DatasetItem()
        {
        }
    }
}