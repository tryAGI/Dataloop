
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryAuditLogsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descending")]
        public bool? Descending { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortBy")]
        public string? SortBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public double? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public double? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toDate")]
        public global::System.DateTime? ToDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromDate")]
        public global::System.DateTime? FromDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityName")]
        public string? EntityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityType")]
        public string? EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAuditLogsRequest" /> class.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="descending"></param>
        /// <param name="sortBy"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="toDate"></param>
        /// <param name="fromDate"></param>
        /// <param name="user"></param>
        /// <param name="action"></param>
        /// <param name="entityName"></param>
        /// <param name="entityType"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryAuditLogsRequest(
            string orgId,
            bool? descending,
            string? sortBy,
            double? pageSize,
            double? page,
            global::System.DateTime? toDate,
            global::System.DateTime? fromDate,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? user,
            string? action,
            string? entityName,
            string? entityType,
            string? id)
        {
            this.Descending = descending;
            this.SortBy = sortBy;
            this.PageSize = pageSize;
            this.Page = page;
            this.ToDate = toDate;
            this.FromDate = fromDate;
            this.User = user;
            this.Action = action;
            this.EntityName = entityName;
            this.EntityType = entityType;
            this.Id = id;
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAuditLogsRequest" /> class.
        /// </summary>
        public QueryAuditLogsRequest()
        {
        }
    }
}