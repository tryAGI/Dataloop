
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickFilesystemDriverConfigurationMountPath
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mountPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilesystemDriverConfigurationMountPath" /> class.
        /// </summary>
        /// <param name="mountPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickFilesystemDriverConfigurationMountPath(
            string mountPath)
        {
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilesystemDriverConfigurationMountPath" /> class.
        /// </summary>
        public PickFilesystemDriverConfigurationMountPath()
        {
        }
    }
}