
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickQueryGeneratorInputAvoidDbCacheOrSelectIdsOnlyOrJoinTermsOrPageSize
    {
        /// <summary>
        /// When true - an arbitrary `$or` term will be added to the query to avoid DB cache<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avoidDbCache")]
        public bool? AvoidDbCache { get; set; }

        /// <summary>
        /// Execute the same queries, but only return the ids of the items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectIdsOnly")]
        public bool? SelectIdsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinTerms")]
        public global::System.Collections.Generic.IList<global::Dataloop.ITermConfiguration>? JoinTerms { get; set; }

        /// <summary>
        /// Determines page size to use for the generated queries<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public double? PageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickQueryGeneratorInputAvoidDbCacheOrSelectIdsOnlyOrJoinTermsOrPageSize" /> class.
        /// </summary>
        /// <param name="avoidDbCache">
        /// When true - an arbitrary `$or` term will be added to the query to avoid DB cache<br/>
        /// Default Value: true
        /// </param>
        /// <param name="selectIdsOnly">
        /// Execute the same queries, but only return the ids of the items
        /// </param>
        /// <param name="joinTerms"></param>
        /// <param name="pageSize">
        /// Determines page size to use for the generated queries<br/>
        /// Default Value: 1000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickQueryGeneratorInputAvoidDbCacheOrSelectIdsOnlyOrJoinTermsOrPageSize(
            bool? avoidDbCache,
            bool? selectIdsOnly,
            global::System.Collections.Generic.IList<global::Dataloop.ITermConfiguration>? joinTerms,
            double? pageSize)
        {
            this.AvoidDbCache = avoidDbCache;
            this.SelectIdsOnly = selectIdsOnly;
            this.JoinTerms = joinTerms;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickQueryGeneratorInputAvoidDbCacheOrSelectIdsOnlyOrJoinTermsOrPageSize" /> class.
        /// </summary>
        public PickQueryGeneratorInputAvoidDbCacheOrSelectIdsOnlyOrJoinTermsOrPageSize()
        {
        }
    }
}