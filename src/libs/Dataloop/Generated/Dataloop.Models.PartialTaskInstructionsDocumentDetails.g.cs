
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialTaskInstructionsDocumentDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.InstructionsDocumentModeJsonConverter))]
        public global::Dataloop.InstructionsDocumentMode? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromPage")]
        public double? FromPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toPage")]
        public double? ToPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTaskInstructionsDocumentDetails" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="fromPage"></param>
        /// <param name="toPage"></param>
        /// <param name="datasetId"></param>
        /// <param name="itemId"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialTaskInstructionsDocumentDetails(
            global::Dataloop.InstructionsDocumentMode? mode,
            double? fromPage,
            double? toPage,
            string? datasetId,
            string? itemId,
            string? name)
        {
            this.Mode = mode;
            this.FromPage = fromPage;
            this.ToPage = toPage;
            this.DatasetId = datasetId;
            this.ItemId = itemId;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTaskInstructionsDocumentDetails" /> class.
        /// </summary>
        public PartialTaskInstructionsDocumentDetails()
        {
        }
    }
}