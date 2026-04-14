
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkComponentDatasetInvoke
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentDatasetInvoke" /> class.
        /// </summary>
        /// <param name="namespace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkComponentDatasetInvoke(
            string @namespace)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentDatasetInvoke" /> class.
        /// </summary>
        public IDpkComponentDatasetInvoke()
        {
        }
    }
}