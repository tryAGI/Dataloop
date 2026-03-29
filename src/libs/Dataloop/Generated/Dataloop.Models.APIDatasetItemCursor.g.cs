
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// For documentation purposes - swagger gen does not handle generics so well...
    /// </summary>
    public sealed partial class APIDatasetItemCursor
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>> Items { get; set; }

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
        /// Initializes a new instance of the <see cref="APIDatasetItemCursor" /> class.
        /// </summary>
        /// <param name="totalItemsCount"></param>
        /// <param name="items"></param>
        /// <param name="totalPagesCount"></param>
        /// <param name="hasNextPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIDatasetItemCursor(
            double totalItemsCount,
            global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>> items,
            double totalPagesCount,
            bool hasNextPage)
        {
            this.TotalItemsCount = totalItemsCount;
            this.Items = items;
            this.TotalPagesCount = totalPagesCount;
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIDatasetItemCursor" /> class.
        /// </summary>
        public APIDatasetItemCursor()
        {
        }
    }
}