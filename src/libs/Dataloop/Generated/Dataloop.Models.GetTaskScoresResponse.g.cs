
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTaskScoresResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNextPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNextPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPagesCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalPagesCount { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Dataloop.APIScore> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTaskScoresResponse" /> class.
        /// </summary>
        /// <param name="hasNextPage"></param>
        /// <param name="totalPagesCount"></param>
        /// <param name="totalItemsCount"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTaskScoresResponse(
            bool hasNextPage,
            double totalPagesCount,
            double totalItemsCount,
            global::System.Collections.Generic.IList<global::Dataloop.APIScore> items)
        {
            this.HasNextPage = hasNextPage;
            this.TotalPagesCount = totalPagesCount;
            this.TotalItemsCount = totalItemsCount;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTaskScoresResponse" /> class.
        /// </summary>
        public GetTaskScoresResponse()
        {
        }
    }
}