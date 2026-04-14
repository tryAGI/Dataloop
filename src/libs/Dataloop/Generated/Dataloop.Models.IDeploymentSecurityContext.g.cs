
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDeploymentSecurityContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runAsUser")]
        public double? RunAsUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runAsGroup")]
        public double? RunAsGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runAsNonRoot")]
        public bool? RunAsNonRoot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fsGroup")]
        public double? FsGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowPrivilegeEscalation")]
        public bool? AllowPrivilegeEscalation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readOnlyRootFilesystem")]
        public bool? ReadOnlyRootFilesystem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDeploymentSecurityContext" /> class.
        /// </summary>
        /// <param name="runAsUser"></param>
        /// <param name="runAsGroup"></param>
        /// <param name="runAsNonRoot"></param>
        /// <param name="fsGroup"></param>
        /// <param name="allowPrivilegeEscalation"></param>
        /// <param name="readOnlyRootFilesystem"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDeploymentSecurityContext(
            double? runAsUser,
            double? runAsGroup,
            bool? runAsNonRoot,
            double? fsGroup,
            bool? allowPrivilegeEscalation,
            bool? readOnlyRootFilesystem)
        {
            this.RunAsUser = runAsUser;
            this.RunAsGroup = runAsGroup;
            this.RunAsNonRoot = runAsNonRoot;
            this.FsGroup = fsGroup;
            this.AllowPrivilegeEscalation = allowPrivilegeEscalation;
            this.ReadOnlyRootFilesystem = readOnlyRootFilesystem;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDeploymentSecurityContext" /> class.
        /// </summary>
        public IDeploymentSecurityContext()
        {
        }
    }
}