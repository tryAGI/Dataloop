
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryEntitiesRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEntitiesRequest" /> class.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="sort"></param>
        /// <param name="filter"></param>
        /// <param name="resource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryEntitiesRequest(
            double pageSize,
            double page,
            object sort,
            object filter,
            string resource)
        {
            this.PageSize = pageSize;
            this.Page = page;
            this.Sort = sort ?? throw new global::System.ArgumentNullException(nameof(sort));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEntitiesRequest" /> class.
        /// </summary>
        public QueryEntitiesRequest()
        {
        }
    }
}