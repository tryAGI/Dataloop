
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIDatasetDirectoryItemExportZip
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIDatasetDirectoryItemExportZip" /> class.
        /// </summary>
        /// <param name="chunks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIDatasetDirectoryItemExportZip(
            global::System.Collections.Generic.IList<string> chunks)
        {
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIDatasetDirectoryItemExportZip" /> class.
        /// </summary>
        public APIDatasetDirectoryItemExportZip()
        {
        }
    }
}