
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportItemRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StorageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public double? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportItemRequest" /> class.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="storageId"></param>
        /// <param name="size"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportItemRequest(
            string filename,
            string storageId,
            double? size)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.StorageId = storageId ?? throw new global::System.ArgumentNullException(nameof(storageId));
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportItemRequest" /> class.
        /// </summary>
        public ImportItemRequest()
        {
        }
    }
}