
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Evaluate input
    /// </summary>
    public sealed partial class EvaluateModelRequestInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetQuery")]
        public global::Dataloop.Dictionary? DatasetQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateModelRequestInput" /> class.
        /// </summary>
        /// <param name="datasetQuery"></param>
        /// <param name="datasetId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluateModelRequestInput(
            global::Dataloop.Dictionary? datasetQuery,
            string? datasetId)
        {
            this.DatasetQuery = datasetQuery;
            this.DatasetId = datasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateModelRequestInput" /> class.
        /// </summary>
        public EvaluateModelRequestInput()
        {
        }
    }
}