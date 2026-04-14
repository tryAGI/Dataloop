
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteOptionsBatchQueryContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<string>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<string>? Datasets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteOptionsBatchQueryContext" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="datasets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteOptionsBatchQueryContext(
            global::System.Collections.Generic.IList<string>? items,
            global::System.Collections.Generic.IList<string>? datasets)
        {
            this.Items = items;
            this.Datasets = datasets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteOptionsBatchQueryContext" /> class.
        /// </summary>
        public ExecuteOptionsBatchQueryContext()
        {
        }
    }
}