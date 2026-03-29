
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DeleteQueryContext Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public double? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?> Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("join")]
        public global::Dataloop.JoinQuery? Join { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public global::Dataloop.Dictionary? Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update")]
        public global::Dataloop.Dictionary? Update { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Delete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("select")]
        public global::Dataloop.Dictionary? Select { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteQuery" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="page"></param>
        /// <param name="resource"></param>
        /// <param name="filter"></param>
        /// <param name="delete"></param>
        /// <param name="pageSize"></param>
        /// <param name="join"></param>
        /// <param name="sort"></param>
        /// <param name="update"></param>
        /// <param name="select"></param>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteQuery(
            global::Dataloop.DeleteQueryContext context,
            double page,
            global::Dataloop.AnyOf<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?> resource,
            global::Dataloop.Dictionary filter,
            bool delete,
            double? pageSize,
            global::Dataloop.JoinQuery? join,
            global::Dataloop.Dictionary? sort,
            global::Dataloop.Dictionary? update,
            global::Dataloop.Dictionary? select,
            double? limit)
        {
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.Page = page;
            this.PageSize = pageSize;
            this.Resource = resource;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Join = join;
            this.Sort = sort;
            this.Update = update;
            this.Delete = delete;
            this.Select = select;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteQuery" /> class.
        /// </summary>
        public DeleteQuery()
        {
        }
    }
}