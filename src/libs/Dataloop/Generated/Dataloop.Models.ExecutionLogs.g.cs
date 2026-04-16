
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionLogs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.ServiceLogEntry> Logs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Stop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint")]
        public string? Checkpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionLogs" /> class.
        /// </summary>
        /// <param name="logs"></param>
        /// <param name="stop"></param>
        /// <param name="id"></param>
        /// <param name="inputs"></param>
        /// <param name="output"></param>
        /// <param name="functionName"></param>
        /// <param name="checkpoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionLogs(
            global::System.Collections.Generic.IList<global::Dataloop.ServiceLogEntry> logs,
            bool stop,
            string id,
            global::Dataloop.Dictionary inputs,
            global::Dataloop.Dictionary output,
            string functionName,
            string? checkpoint)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.Stop = stop;
            this.Checkpoint = checkpoint;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.FunctionName = functionName ?? throw new global::System.ArgumentNullException(nameof(functionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionLogs" /> class.
        /// </summary>
        public ExecutionLogs()
        {
        }
    }
}