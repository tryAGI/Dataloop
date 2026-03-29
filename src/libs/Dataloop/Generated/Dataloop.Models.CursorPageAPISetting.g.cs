
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CursorPageAPISetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalItemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalItemsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.APIMetric> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPagesCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalPagesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNextPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPageAPISetting" /> class.
        /// </summary>
        /// <param name="totalItemsCount"></param>
        /// <param name="items"></param>
        /// <param name="totalPagesCount"></param>
        /// <param name="hasNextPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CursorPageAPISetting(
            double totalItemsCount,
            global::System.Collections.Generic.IList<global::Dataloop.APIMetric> items,
            double totalPagesCount,
            bool hasNextPage)
        {
            this.TotalItemsCount = totalItemsCount;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.TotalPagesCount = totalPagesCount;
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPageAPISetting" /> class.
        /// </summary>
        public CursorPageAPISetting()
        {
        }
    }
}