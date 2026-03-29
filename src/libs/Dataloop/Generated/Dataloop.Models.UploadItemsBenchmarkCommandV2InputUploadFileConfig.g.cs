
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadItemsBenchmarkCommandV2InputUploadFileConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filePath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadItemsBenchmarkCommandV2InputUploadFileConfig" /> class.
        /// </summary>
        /// <param name="filePath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadItemsBenchmarkCommandV2InputUploadFileConfig(
            string filePath)
        {
            this.FilePath = filePath ?? throw new global::System.ArgumentNullException(nameof(filePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadItemsBenchmarkCommandV2InputUploadFileConfig" /> class.
        /// </summary>
        public UploadItemsBenchmarkCommandV2InputUploadFileConfig()
        {
        }
    }
}