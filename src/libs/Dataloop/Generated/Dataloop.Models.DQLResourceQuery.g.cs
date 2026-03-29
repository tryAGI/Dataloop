
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DQLResourceQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("join")]
        public global::Dataloop.JoinQuery? Join { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intersect")]
        public global::Dataloop.IntersectQuery? Intersect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("except")]
        public global::Dataloop.IntersectQuery? Except { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::Dataloop.ReferenceQuery? References { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public global::Dataloop.SortQuery? Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("select")]
        public global::System.Collections.Generic.Dictionary<string, double>? Select { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update")]
        public global::Dataloop.Dictionary? Update { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete")]
        public bool? Delete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemSpace")]
        public bool? SystemSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryEngine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DQLResourceQueryQueryEngineJsonConverter))]
        public global::Dataloop.DQLResourceQueryQueryEngine? QueryEngine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.QueryResourceJsonConverter))]
        public global::Dataloop.QueryResource? Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public double? Skip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<string>? Datasets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<string>? Projects { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("collectMetrics")]
        public bool? CollectMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countTotal")]
        public bool? CountTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sign")]
        public global::Dataloop.DQLResourceQuerySign? Sign { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DQLResourceQuery" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="limit"></param>
        /// <param name="join"></param>
        /// <param name="intersect"></param>
        /// <param name="except"></param>
        /// <param name="references"></param>
        /// <param name="sort"></param>
        /// <param name="select"></param>
        /// <param name="update"></param>
        /// <param name="delete"></param>
        /// <param name="user"></param>
        /// <param name="systemSpace"></param>
        /// <param name="queryEngine"></param>
        /// <param name="resource"></param>
        /// <param name="skip"></param>
        /// <param name="datasets"></param>
        /// <param name="projects"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="collectMetrics"></param>
        /// <param name="countTotal"></param>
        /// <param name="sign"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DQLResourceQuery(
            global::Dataloop.Dictionary filter,
            double? limit,
            global::Dataloop.JoinQuery? join,
            global::Dataloop.IntersectQuery? intersect,
            global::Dataloop.IntersectQuery? except,
            global::Dataloop.ReferenceQuery? references,
            global::Dataloop.SortQuery? sort,
            global::System.Collections.Generic.Dictionary<string, double>? select,
            global::Dataloop.Dictionary? update,
            bool? delete,
            string? user,
            bool? systemSpace,
            global::Dataloop.DQLResourceQueryQueryEngine? queryEngine,
            global::Dataloop.QueryResource? resource,
            double? skip,
            global::System.Collections.Generic.IList<string>? datasets,
            global::System.Collections.Generic.IList<string>? projects,
            double? page,
            double? pageSize,
            bool? collectMetrics,
            bool? countTotal,
            global::Dataloop.DQLResourceQuerySign? sign)
        {
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Limit = limit;
            this.Join = join;
            this.Intersect = intersect;
            this.Except = except;
            this.References = references;
            this.Sort = sort;
            this.Select = select;
            this.Update = update;
            this.Delete = delete;
            this.User = user;
            this.SystemSpace = systemSpace;
            this.QueryEngine = queryEngine;
            this.Resource = resource;
            this.Skip = skip;
            this.Datasets = datasets;
            this.Projects = projects;
            this.Page = page;
            this.PageSize = pageSize;
            this.CollectMetrics = collectMetrics;
            this.CountTotal = countTotal;
            this.Sign = sign;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DQLResourceQuery" /> class.
        /// </summary>
        public DQLResourceQuery()
        {
        }
    }
}