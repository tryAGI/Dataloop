
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeatureSet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// type - string of the feature type: 2d, 3d, modelFC, TSNE, PCA, FFT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.FeatureSetEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.FeatureSetEntityType EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// size - set size
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authz")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AuthZBlockDatasetContext Authz { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureSet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type">
        /// type - string of the feature type: 2d, 3d, modelFC, TSNE, PCA, FFT
        /// </param>
        /// <param name="entityType"></param>
        /// <param name="project"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="name"></param>
        /// <param name="size">
        /// size - set size
        /// </param>
        /// <param name="authz"></param>
        /// <param name="org"></param>
        /// <param name="modelId"></param>
        /// <param name="creator"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeatureSet(
            string id,
            string type,
            global::Dataloop.FeatureSetEntityType entityType,
            string project,
            global::System.DateTime createdAt,
            string updatedBy,
            string name,
            double size,
            global::Dataloop.AuthZBlockDatasetContext authz,
            string? org,
            string? modelId,
            string? creator,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.EntityType = entityType;
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Org = org;
            this.ModelId = modelId;
            this.Creator = creator;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy ?? throw new global::System.ArgumentNullException(nameof(updatedBy));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Size = size;
            this.Authz = authz ?? throw new global::System.ArgumentNullException(nameof(authz));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureSet" /> class.
        /// </summary>
        public FeatureSet()
        {
        }
    }
}