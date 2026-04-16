
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.QueryString Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logsOptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.LogQuery LogsOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogsRequest" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="logsOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogsRequest(
            global::Dataloop.QueryString query,
            global::Dataloop.LogQuery logsOptions)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.LogsOptions = logsOptions ?? throw new global::System.ArgumentNullException(nameof(logsOptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogsRequest" /> class.
        /// </summary>
        public LogsRequest()
        {
        }
    }
}