
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIPipelineVersion
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
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineId")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double VersionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Snapshot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restoredFromVersionNumber")]
        public double? RestoredFromVersionNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPipelineVersion" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="versionNumber"></param>
        /// <param name="createdAt"></param>
        /// <param name="snapshot"></param>
        /// <param name="pipelineId"></param>
        /// <param name="createdBy"></param>
        /// <param name="source"></param>
        /// <param name="restoredFromVersionNumber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIPipelineVersion(
            string id,
            string url,
            double versionNumber,
            global::System.DateTime createdAt,
            global::Dataloop.Dictionary snapshot,
            string? pipelineId,
            string? createdBy,
            string? source,
            double? restoredFromVersionNumber)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PipelineId = pipelineId;
            this.VersionNumber = versionNumber;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Source = source;
            this.Snapshot = snapshot ?? throw new global::System.ArgumentNullException(nameof(snapshot));
            this.RestoredFromVersionNumber = restoredFromVersionNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPipelineVersion" /> class.
        /// </summary>
        public APIPipelineVersion()
        {
        }
    }
}