
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceMetadataMl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelOperation")]
        public string? ModelOperation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMetadataMl" /> class.
        /// </summary>
        /// <param name="modelOperation"></param>
        /// <param name="modelId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceMetadataMl(
            string? modelOperation,
            string? modelId)
        {
            this.ModelOperation = modelOperation;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMetadataMl" /> class.
        /// </summary>
        public ServiceMetadataMl()
        {
        }
    }
}