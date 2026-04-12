
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IClusterVolumeNfs
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
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Server { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterVolumeNfs" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="server"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IClusterVolumeNfs(
            string path,
            string server)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Server = server ?? throw new global::System.ArgumentNullException(nameof(server));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterVolumeNfs" /> class.
        /// </summary>
        public IClusterVolumeNfs()
        {
        }
    }
}