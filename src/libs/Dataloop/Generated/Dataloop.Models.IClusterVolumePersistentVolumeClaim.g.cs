
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IClusterVolumePersistentVolumeClaim
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClaimName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterVolumePersistentVolumeClaim" /> class.
        /// </summary>
        /// <param name="claimName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IClusterVolumePersistentVolumeClaim(
            string claimName)
        {
            this.ClaimName = claimName ?? throw new global::System.ArgumentNullException(nameof(claimName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterVolumePersistentVolumeClaim" /> class.
        /// </summary>
        public IClusterVolumePersistentVolumeClaim()
        {
        }
    }
}