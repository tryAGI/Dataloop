
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ItemCloneRequest
    {
        /// <summary>
        /// Target dataset id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetDatasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetDatasetId { get; set; }

        /// <summary>
        /// path at target dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteFileName")]
        public string? RemoteFileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.Dictionary? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloneDatasetParams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CloneDatasetParams CloneDatasetParams { get; set; }

        /// <summary>
        /// allow multiple copies of the same source item<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowMany")]
        public bool? AllowMany { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemCloneRequest" /> class.
        /// </summary>
        /// <param name="targetDatasetId">
        /// Target dataset id
        /// </param>
        /// <param name="cloneDatasetParams"></param>
        /// <param name="remoteFileName">
        /// path at target dataset
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="allowMany">
        /// allow multiple copies of the same source item<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemCloneRequest(
            string targetDatasetId,
            global::Dataloop.CloneDatasetParams cloneDatasetParams,
            string? remoteFileName,
            global::Dataloop.Dictionary? metadata,
            bool? allowMany)
        {
            this.TargetDatasetId = targetDatasetId ?? throw new global::System.ArgumentNullException(nameof(targetDatasetId));
            this.RemoteFileName = remoteFileName;
            this.Metadata = metadata;
            this.CloneDatasetParams = cloneDatasetParams ?? throw new global::System.ArgumentNullException(nameof(cloneDatasetParams));
            this.AllowMany = allowMany;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemCloneRequest" /> class.
        /// </summary>
        public ItemCloneRequest()
        {
        }
    }
}