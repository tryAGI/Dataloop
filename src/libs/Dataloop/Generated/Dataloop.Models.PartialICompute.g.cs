
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialICompute
    {
        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Dataloop.IComputeContext? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharedContexts")]
        public global::System.Collections.Generic.IList<global::Dataloop.IComputeContext>? SharedContexts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        public bool? Global { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("orgIds")]
        public global::System.Collections.Generic.IList<string>? OrgIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EComputeTypeJsonConverter))]
        public global::Dataloop.EComputeType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ComputeMetadataJsonConverter))]
        public global::Dataloop.ComputeMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EComputeStatusJsonConverter))]
        public global::Dataloop.EComputeStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Dataloop.IComputeSettings? Settings { get; set; }

        /// <summary>
        /// User id or email of the user who created the compute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultNamespace")]
        public string? DefaultNamespace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialICompute" /> class.
        /// </summary>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="name"></param>
        /// <param name="context"></param>
        /// <param name="sharedContexts"></param>
        /// <param name="global"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="orgIds"></param>
        /// <param name="type"></param>
        /// <param name="metadata"></param>
        /// <param name="status"></param>
        /// <param name="archived"></param>
        /// <param name="settings"></param>
        /// <param name="createdBy">
        /// User id or email of the user who created the compute
        /// </param>
        /// <param name="defaultNamespace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialICompute(
            string? id,
            string? name,
            global::Dataloop.IComputeContext? context,
            global::System.Collections.Generic.IList<global::Dataloop.IComputeContext>? sharedContexts,
            bool? global,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<string>? orgIds,
            global::Dataloop.EComputeType? type,
            global::Dataloop.ComputeMetadata? metadata,
            global::Dataloop.EComputeStatus? status,
            bool? archived,
            global::Dataloop.IComputeSettings? settings,
            string? createdBy,
            string? defaultNamespace)
        {
            this.Id = id;
            this.Name = name;
            this.Context = context;
            this.SharedContexts = sharedContexts;
            this.Global = global;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.OrgIds = orgIds;
            this.Type = type;
            this.Metadata = metadata;
            this.Status = status;
            this.Archived = archived;
            this.Settings = settings;
            this.CreatedBy = createdBy;
            this.DefaultNamespace = defaultNamespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialICompute" /> class.
        /// </summary>
        public PartialICompute()
        {
        }
    }
}