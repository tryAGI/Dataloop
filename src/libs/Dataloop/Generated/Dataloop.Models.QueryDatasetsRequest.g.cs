
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryDatasetsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.QueryDatasetsRequestTargetJsonConverter))]
        public global::Dataloop.QueryDatasetsRequestTarget Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery> Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryDatasetsRequest" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="target"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryDatasetsRequest(
            global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery> query,
            global::Dataloop.QueryDatasetsRequestTarget target)
        {
            this.Target = target;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryDatasetsRequest" /> class.
        /// </summary>
        public QueryDatasetsRequest()
        {
        }
    }
}