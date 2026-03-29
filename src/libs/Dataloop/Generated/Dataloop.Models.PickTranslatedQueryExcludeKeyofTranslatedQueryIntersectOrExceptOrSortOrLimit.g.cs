
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickTranslatedQueryExcludeKeyofTranslatedQueryIntersectOrExceptOrSortOrLimit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("select")]
        public object? Select { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resource { get; set; }

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
        /// Initializes a new instance of the <see cref="PickTranslatedQueryExcludeKeyofTranslatedQueryIntersectOrExceptOrSortOrLimit" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="resource"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="withStatement"></param>
        /// <param name="groupBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickTranslatedQueryExcludeKeyofTranslatedQueryIntersectOrExceptOrSortOrLimit(
            object filter,
            string resource,
            object? select,
            object? join,
            object? withStatement,
            object? groupBy)
        {
            this.Select = select;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Join = join;
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.WithStatement = withStatement;
            this.GroupBy = groupBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickTranslatedQueryExcludeKeyofTranslatedQueryIntersectOrExceptOrSortOrLimit" /> class.
        /// </summary>
        public PickTranslatedQueryExcludeKeyofTranslatedQueryIntersectOrExceptOrSortOrLimit()
        {
        }
    }
}