
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IExecuteOptionsBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.JsExecuteOptionsBatchQuery Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::Dataloop.Dictionary? Args { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IExecuteOptionsBatch" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="args"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IExecuteOptionsBatch(
            global::Dataloop.JsExecuteOptionsBatchQuery query,
            global::Dataloop.Dictionary? args)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Args = args;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IExecuteOptionsBatch" /> class.
        /// </summary>
        public IExecuteOptionsBatch()
        {
        }
    }
}