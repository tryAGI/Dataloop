
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIFeatureVector
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
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// value - actual vector - immutable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Value { get; set; }

        /// <summary>
        /// featureSetId - ref to a featureSet this vector is a part of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featureSetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeatureSetId { get; set; }

        /// <summary>
        /// datasetId - ref to a featureSet this vector is a part of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// version - version of the feature set generator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// parentId - used when FeatureVector is a subFeature
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

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
        /// Initializes a new instance of the <see cref="APIFeatureVector" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="entityId"></param>
        /// <param name="project"></param>
        /// <param name="creator"></param>
        /// <param name="createdAt"></param>
        /// <param name="value">
        /// value - actual vector - immutable
        /// </param>
        /// <param name="featureSetId">
        /// featureSetId - ref to a featureSet this vector is a part of
        /// </param>
        /// <param name="datasetId">
        /// datasetId - ref to a featureSet this vector is a part of
        /// </param>
        /// <param name="version">
        /// version - version of the feature set generator
        /// </param>
        /// <param name="authz"></param>
        /// <param name="org"></param>
        /// <param name="parentId">
        /// parentId - used when FeatureVector is a subFeature
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIFeatureVector(
            string id,
            string url,
            string entityId,
            string project,
            string creator,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<double> value,
            string featureSetId,
            string datasetId,
            string version,
            global::Dataloop.AuthZBlockDatasetContext authz,
            string? org,
            string? parentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.Org = org;
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.CreatedAt = createdAt;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.FeatureSetId = featureSetId ?? throw new global::System.ArgumentNullException(nameof(featureSetId));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.ParentId = parentId;
            this.Authz = authz ?? throw new global::System.ArgumentNullException(nameof(authz));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIFeatureVector" /> class.
        /// </summary>
        public APIFeatureVector()
        {
        }
    }
}