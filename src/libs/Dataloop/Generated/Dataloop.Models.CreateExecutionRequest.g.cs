
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExecutionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ExecutionModeJsonConverter))]
        public global::Dataloop.ExecutionMode? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        public global::Dataloop.IPipelineExecution? Pipeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        public global::Dataloop.ExecuteOptionsBatch? Batch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExecutionRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="input"></param>
        /// <param name="functionName"></param>
        /// <param name="mode"></param>
        /// <param name="pipeline"></param>
        /// <param name="batch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExecutionRequest(
            string projectId,
            global::Dataloop.Dictionary input,
            string functionName,
            global::Dataloop.ExecutionMode? mode,
            global::Dataloop.IPipelineExecution? pipeline,
            global::Dataloop.ExecuteOptionsBatch? batch)
        {
            this.Mode = mode;
            this.Pipeline = pipeline;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.FunctionName = functionName ?? throw new global::System.ArgumentNullException(nameof(functionName));
            this.Batch = batch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExecutionRequest" /> class.
        /// </summary>
        public CreateExecutionRequest()
        {
        }
    }
}