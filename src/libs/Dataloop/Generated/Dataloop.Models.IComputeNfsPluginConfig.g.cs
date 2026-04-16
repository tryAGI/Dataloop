
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// NFS plugin: in-cluster nfs-server backing PVC size (Kubernetes quantity, e.g. "10Gi")
    /// </summary>
    public sealed partial class IComputeNfsPluginConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storageSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StorageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeNfsPluginConfig" /> class.
        /// </summary>
        /// <param name="storageSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IComputeNfsPluginConfig(
            string storageSize)
        {
            this.StorageSize = storageSize ?? throw new global::System.ArgumentNullException(nameof(storageSize));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeNfsPluginConfig" /> class.
        /// </summary>
        public IComputeNfsPluginConfig()
        {
        }
    }
}