
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIAssignmentRemoveItemsProcess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIAssignmentRemoveItemsProcess" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="date"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIAssignmentRemoveItemsProcess(
            double count,
            global::System.DateTime date)
        {
            this.Count = count;
            this.Date = date;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIAssignmentRemoveItemsProcess" /> class.
        /// </summary>
        public APIAssignmentRemoveItemsProcess()
        {
        }
    }
}