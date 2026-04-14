
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IClusterVolume
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mountPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subPath")]
        public string? SubPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readOnly")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persistentVolumeClaim")]
        public global::Dataloop.IClusterVolumePersistentVolumeClaim? PersistentVolumeClaim { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emptyDir")]
        public object? EmptyDir { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostPath")]
        public global::Dataloop.IClusterVolumeHostPath? HostPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configMap")]
        public global::Dataloop.IClusterVolumeConfigMap? ConfigMap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public global::Dataloop.IClusterVolumeSecret? Secret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nfs")]
        public global::Dataloop.IClusterVolumeNfs? Nfs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterVolume" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mountPath"></param>
        /// <param name="subPath"></param>
        /// <param name="readOnly"></param>
        /// <param name="persistentVolumeClaim"></param>
        /// <param name="emptyDir"></param>
        /// <param name="hostPath"></param>
        /// <param name="configMap"></param>
        /// <param name="secret"></param>
        /// <param name="nfs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IClusterVolume(
            string name,
            string mountPath,
            string? subPath,
            bool? readOnly,
            global::Dataloop.IClusterVolumePersistentVolumeClaim? persistentVolumeClaim,
            object? emptyDir,
            global::Dataloop.IClusterVolumeHostPath? hostPath,
            global::Dataloop.IClusterVolumeConfigMap? configMap,
            global::Dataloop.IClusterVolumeSecret? secret,
            global::Dataloop.IClusterVolumeNfs? nfs)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.SubPath = subPath;
            this.ReadOnly = readOnly;
            this.PersistentVolumeClaim = persistentVolumeClaim;
            this.EmptyDir = emptyDir;
            this.HostPath = hostPath;
            this.ConfigMap = configMap;
            this.Secret = secret;
            this.Nfs = nfs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterVolume" /> class.
        /// </summary>
        public IClusterVolume()
        {
        }
    }
}