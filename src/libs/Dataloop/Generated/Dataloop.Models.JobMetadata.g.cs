
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        public string? AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panelName")]
        public string? PanelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mountFilePath")]
        public string? MountFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobMetadata" /> class.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="panelName"></param>
        /// <param name="mountFilePath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobMetadata(
            string? appId,
            string? panelName,
            string? mountFilePath)
        {
            this.AppId = appId;
            this.PanelName = panelName;
            this.MountFilePath = mountFilePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobMetadata" /> class.
        /// </summary>
        public JobMetadata()
        {
        }
    }
}