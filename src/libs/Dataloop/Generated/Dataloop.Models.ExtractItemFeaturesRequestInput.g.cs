
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// embed input
    /// </summary>
    public sealed partial class ExtractItemFeaturesRequestInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetQuery")]
        public global::Dataloop.Dictionary? DatasetQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemIds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? ItemIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractItemFeaturesRequestInput" /> class.
        /// </summary>
        /// <param name="datasetQuery"></param>
        /// <param name="datasetId"></param>
        /// <param name="itemIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractItemFeaturesRequestInput(
            global::Dataloop.Dictionary? datasetQuery,
            string? datasetId,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? itemIds)
        {
            this.DatasetQuery = datasetQuery;
            this.DatasetId = datasetId;
            this.ItemIds = itemIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractItemFeaturesRequestInput" /> class.
        /// </summary>
        public ExtractItemFeaturesRequestInput()
        {
        }
    }
}