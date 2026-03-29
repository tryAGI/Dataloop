
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslatedQuery
    {
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
        public required object Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("join")]
        public object? Join { get; set; }

        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intersect")]
        public global::Dataloop.PickTranslatedQueryExcludeKeyofTranslatedQueryIntersectOrExceptOrSortOrLimit? Intersect { get; set; }

        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("except")]
        public global::Dataloop.PickTranslatedQueryExcludeKeyofTranslatedQueryIntersectOrExceptOrSortOrLimit? Except { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public object? Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public global::Dataloop.DqlLimit? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("select")]
        public object? Select { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withStatement")]
        public object? WithStatement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        public object? GroupBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslatedQuery" /> class.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="filter"></param>
        /// <param name="join"></param>
        /// <param name="intersect">
        /// From T, pick a set of properties whose keys are in the union K
        /// </param>
        /// <param name="except">
        /// From T, pick a set of properties whose keys are in the union K
        /// </param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="select"></param>
        /// <param name="withStatement"></param>
        /// <param name="groupBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslatedQuery(
            string resource,
            object filter,
            object? join,
            global::Dataloop.PickTranslatedQueryExcludeKeyofTranslatedQueryIntersectOrExceptOrSortOrLimit? intersect,
            global::Dataloop.PickTranslatedQueryExcludeKeyofTranslatedQueryIntersectOrExceptOrSortOrLimit? except,
            object? sort,
            global::Dataloop.DqlLimit? limit,
            object? select,
            object? withStatement,
            object? groupBy)
        {
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Join = join;
            this.Intersect = intersect;
            this.Except = except;
            this.Sort = sort;
            this.Limit = limit;
            this.Select = select;
            this.WithStatement = withStatement;
            this.GroupBy = groupBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslatedQuery" /> class.
        /// </summary>
        public TranslatedQuery()
        {
        }
    }
}