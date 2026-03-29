
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoginsLogQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.LoginsLogQueryOrderJsonConverter))]
        public global::Dataloop.LoginsLogQueryOrder? Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.LoginsLogQueryOrderByJsonConverter))]
        public global::Dataloop.LoginsLogQueryOrderBy? OrderBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public double? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public double? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupId")]
        public string? GroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgRole")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.OrgRoleJsonConverter))]
        public global::Dataloop.OrgRole? OrgRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginsLogQuery" /> class.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="groupId"></param>
        /// <param name="orgRole"></param>
        /// <param name="userId"></param>
        /// <param name="toDate"></param>
        /// <param name="fromDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoginsLogQuery(
            string orgId,
            global::Dataloop.LoginsLogQueryOrder? order,
            global::Dataloop.LoginsLogQueryOrderBy? orderBy,
            double? page,
            double? pageSize,
            string? groupId,
            global::Dataloop.OrgRole? orgRole,
            string? userId,
            global::System.DateTime? toDate,
            global::System.DateTime? fromDate)
        {
            this.Order = order;
            this.OrderBy = orderBy;
            this.Page = page;
            this.PageSize = pageSize;
            this.GroupId = groupId;
            this.OrgRole = orgRole;
            this.UserId = userId;
            this.ToDate = toDate;
            this.FromDate = fromDate;
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginsLogQuery" /> class.
        /// </summary>
        public LoginsLogQuery()
        {
        }
    }
}