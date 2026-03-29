
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialAPIEmbedDatasetsSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetIds")]
        public global::System.Collections.Generic.IList<string>? DatasetIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachTrigger")]
        public bool? AttachTrigger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Dataloop.PartialAPIEmbedDatasetsSpecConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAPIEmbedDatasetsSpec" /> class.
        /// </summary>
        /// <param name="datasetIds"></param>
        /// <param name="attachTrigger"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialAPIEmbedDatasetsSpec(
            global::System.Collections.Generic.IList<string>? datasetIds,
            bool? attachTrigger,
            global::Dataloop.PartialAPIEmbedDatasetsSpecConfig? config)
        {
            this.DatasetIds = datasetIds;
            this.AttachTrigger = attachTrigger;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAPIEmbedDatasetsSpec" /> class.
        /// </summary>
        public PartialAPIEmbedDatasetsSpec()
        {
        }
    }
}