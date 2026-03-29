
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelect
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
        [global::System.Text.Json.Serialization.JsonPropertyName("join")]
        public global::Dataloop.JoinQuery? Join { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::Dataloop.ReferenceQuery? References { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngineJsonConverter))]
        public global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine? QueryEngine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelect" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="join"></param>
        /// <param name="references"></param>
        /// <param name="update"></param>
        /// <param name="delete"></param>
        /// <param name="user"></param>
        /// <param name="systemSpace"></param>
        /// <param name="queryEngine"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelect(
            global::Dataloop.Dictionary filter,
            global::Dataloop.JoinQuery? join,
            global::Dataloop.ReferenceQuery? references,
            global::Dataloop.Dictionary? update,
            bool? delete,
            string? user,
            bool? systemSpace,
            global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine? queryEngine)
        {
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Join = join;
            this.References = references;
            this.Update = update;
            this.Delete = delete;
            this.User = user;
            this.SystemSpace = systemSpace;
            this.QueryEngine = queryEngine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelect" /> class.
        /// </summary>
        public PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelect()
        {
        }
    }
}