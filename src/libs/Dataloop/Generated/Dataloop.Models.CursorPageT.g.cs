
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CursorPageT
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>> Items { get; set; }

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
        /// Initializes a new instance of the <see cref="CursorPageT" /> class.
        /// </summary>
        /// <param name="totalItemsCount"></param>
        /// <param name="items"></param>
        /// <param name="totalPagesCount"></param>
        /// <param name="hasNextPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CursorPageT(
            double totalItemsCount,
            global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>> items,
            double totalPagesCount,
            bool hasNextPage)
        {
            this.TotalItemsCount = totalItemsCount;
            this.Items = items;
            this.TotalPagesCount = totalPagesCount;
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPageT" /> class.
        /// </summary>
        public CursorPageT()
        {
        }
    }
}