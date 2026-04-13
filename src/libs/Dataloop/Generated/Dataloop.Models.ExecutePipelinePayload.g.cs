
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutePipelinePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testMode")]
        public bool? TestMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutePipelinePayload" /> class.
        /// </summary>
        /// <param name="testMode"></param>
        /// <param name="input"></param>
        /// <param name="nodeId"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutePipelinePayload(
            bool? testMode,
            object? input,
            string? nodeId,
            string? id)
        {
            this.TestMode = testMode;
            this.Input = input;
            this.NodeId = nodeId;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutePipelinePayload" /> class.
        /// </summary>
        public ExecutePipelinePayload()
        {
        }
    }
}