
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterQueryInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.FilterQueryInputContext Context { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resource { get; set; }

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
        public global::Dataloop.Dictionary? Join { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public global::Dataloop.Dictionary? Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemSpace")]
        public bool? SystemSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::Dataloop.FilterQueryInputReferences? References { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterQueryInput" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="resource"></param>
        /// <param name="filter"></param>
        /// <param name="join"></param>
        /// <param name="update"></param>
        /// <param name="delete"></param>
        /// <param name="sort"></param>
        /// <param name="systemSpace"></param>
        /// <param name="references"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterQueryInput(
            global::Dataloop.FilterQueryInputContext context,
            double page,
            double pageSize,
            string resource,
            global::Dataloop.Dictionary filter,
            global::Dataloop.Dictionary? join,
            global::Dataloop.Dictionary? update,
            bool? delete,
            global::Dataloop.Dictionary? sort,
            bool? systemSpace,
            global::Dataloop.FilterQueryInputReferences? references)
        {
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.Page = page;
            this.PageSize = pageSize;
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Join = join;
            this.Update = update;
            this.Delete = delete;
            this.Sort = sort;
            this.SystemSpace = systemSpace;
            this.References = references;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterQueryInput" /> class.
        /// </summary>
        public FilterQueryInput()
        {
        }
    }
}