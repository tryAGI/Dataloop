
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetsByProjectIdsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Datasets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsByProjectIdsResponse" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="datasets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDatasetsByProjectIdsResponse(
            double total,
            global::System.Collections.Generic.IList<object> datasets)
        {
            this.Total = total;
            this.Datasets = datasets ?? throw new global::System.ArgumentNullException(nameof(datasets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsByProjectIdsResponse" /> class.
        /// </summary>
        public GetDatasetsByProjectIdsResponse()
        {
        }
    }
}