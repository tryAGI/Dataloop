
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelineVersionListItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Version { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.PartialIPipeline Snapshot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineVersionListItem" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="version"></param>
        /// <param name="snapshot">
        /// Make all properties in T optional
        /// </param>
        /// <param name="createdBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineVersionListItem(
            global::System.DateTime createdAt,
            double version,
            global::Dataloop.PartialIPipeline snapshot,
            string? createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.Version = version;
            this.Snapshot = snapshot ?? throw new global::System.ArgumentNullException(nameof(snapshot));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineVersionListItem" /> class.
        /// </summary>
        public PipelineVersionListItem()
        {
        }

    }
}