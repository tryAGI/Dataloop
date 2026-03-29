
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListExportHistoryRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortOrder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ListExportHistoryRequestSortOrderJsonConverter))]
        public global::Dataloop.ListExportHistoryRequestSortOrder? SortOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ListExportHistoryRequestSortByJsonConverter))]
        public global::Dataloop.ListExportHistoryRequestSortBy? SortBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public double? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageOffset")]
        public double? PageOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportId")]
        public string? ExportId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportHistoryRequest" /> class.
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="sortOrder"></param>
        /// <param name="sortBy"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageOffset"></param>
        /// <param name="exportId"></param>
        /// <param name="creator"></param>
        /// <param name="datasetId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListExportHistoryRequest(
            global::System.Collections.Generic.IList<string> projects,
            global::Dataloop.ListExportHistoryRequestSortOrder? sortOrder,
            global::Dataloop.ListExportHistoryRequestSortBy? sortBy,
            double? pageSize,
            double? pageOffset,
            string? exportId,
            string? creator,
            string? datasetId)
        {
            this.SortOrder = sortOrder;
            this.SortBy = sortBy;
            this.PageSize = pageSize;
            this.PageOffset = pageOffset;
            this.ExportId = exportId;
            this.Creator = creator;
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.DatasetId = datasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportHistoryRequest" /> class.
        /// </summary>
        public ListExportHistoryRequest()
        {
        }
    }
}