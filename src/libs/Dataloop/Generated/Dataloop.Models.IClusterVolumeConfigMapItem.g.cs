
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IClusterVolumeConfigMapItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterVolumeConfigMapItem" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="key"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IClusterVolumeConfigMapItem(
            string path,
            string key)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterVolumeConfigMapItem" /> class.
        /// </summary>
        public IClusterVolumeConfigMapItem()
        {
        }
    }
}