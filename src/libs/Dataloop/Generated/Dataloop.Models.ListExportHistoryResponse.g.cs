
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListExportHistoryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageOffset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.APIExportHistory> Records { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportHistoryResponse" /> class.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageOffset"></param>
        /// <param name="records"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListExportHistoryResponse(
            double pageSize,
            double pageOffset,
            global::System.Collections.Generic.IList<global::Dataloop.APIExportHistory> records,
            double total)
        {
            this.PageSize = pageSize;
            this.PageOffset = pageOffset;
            this.Records = records ?? throw new global::System.ArgumentNullException(nameof(records));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportHistoryResponse" /> class.
        /// </summary>
        public ListExportHistoryResponse()
        {
        }
    }
}