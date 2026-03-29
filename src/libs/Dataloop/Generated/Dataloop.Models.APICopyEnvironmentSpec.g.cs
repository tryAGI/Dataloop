
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APICopyEnvironmentSpec
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloneModelRequest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.PartialCreateModelRequest CloneModelRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromDatasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromProjectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloneDatasetName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloneDatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromDatasetFilter")]
        public global::Dataloop.Dictionary? FromDatasetFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromArtifactItemId")]
        public string? FromArtifactItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clonedModelId")]
        public string? ClonedModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clonedBucketItemId")]
        public string? ClonedBucketItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clonedDatasetId")]
        public string? ClonedDatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APICopyEnvironmentSpec" /> class.
        /// </summary>
        /// <param name="cloneModelRequest">
        /// Make all properties in T optional
        /// </param>
        /// <param name="fromDatasetId"></param>
        /// <param name="fromProjectId"></param>
        /// <param name="cloneDatasetName"></param>
        /// <param name="fromDatasetFilter"></param>
        /// <param name="fromArtifactItemId"></param>
        /// <param name="clonedModelId"></param>
        /// <param name="clonedBucketItemId"></param>
        /// <param name="clonedDatasetId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APICopyEnvironmentSpec(
            global::Dataloop.PartialCreateModelRequest cloneModelRequest,
            string fromDatasetId,
            string fromProjectId,
            string cloneDatasetName,
            global::Dataloop.Dictionary? fromDatasetFilter,
            string? fromArtifactItemId,
            string? clonedModelId,
            string? clonedBucketItemId,
            string? clonedDatasetId)
        {
            this.CloneModelRequest = cloneModelRequest ?? throw new global::System.ArgumentNullException(nameof(cloneModelRequest));
            this.FromDatasetId = fromDatasetId ?? throw new global::System.ArgumentNullException(nameof(fromDatasetId));
            this.FromProjectId = fromProjectId ?? throw new global::System.ArgumentNullException(nameof(fromProjectId));
            this.CloneDatasetName = cloneDatasetName ?? throw new global::System.ArgumentNullException(nameof(cloneDatasetName));
            this.FromDatasetFilter = fromDatasetFilter;
            this.FromArtifactItemId = fromArtifactItemId;
            this.ClonedModelId = clonedModelId;
            this.ClonedBucketItemId = clonedBucketItemId;
            this.ClonedDatasetId = clonedDatasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APICopyEnvironmentSpec" /> class.
        /// </summary>
        public APICopyEnvironmentSpec()
        {
        }
    }
}