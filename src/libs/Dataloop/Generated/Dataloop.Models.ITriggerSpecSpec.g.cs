
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ITriggerSpecSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::Dataloop.Dictionary? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endAt")]
        public global::System.DateTime? EndAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startAt")]
        public global::System.DateTime? StartAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron")]
        public string? Cron { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public global::Dataloop.TriggerOperation? Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ExecutionModeJsonConverter))]
        public global::Dataloop.ExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::Dataloop.TriggerActionType>? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.TriggerResourceTypeJsonConverter))]
        public global::Dataloop.TriggerResourceType? Resource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ITriggerSpecSpec" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="endAt"></param>
        /// <param name="startAt"></param>
        /// <param name="cron"></param>
        /// <param name="operation"></param>
        /// <param name="filter"></param>
        /// <param name="executionMode"></param>
        /// <param name="actions"></param>
        /// <param name="resource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ITriggerSpecSpec(
            global::Dataloop.Dictionary? input,
            global::System.DateTime? endAt,
            global::System.DateTime? startAt,
            string? cron,
            global::Dataloop.TriggerOperation? operation,
            string? filter,
            global::Dataloop.ExecutionMode? executionMode,
            global::System.Collections.Generic.IList<global::Dataloop.TriggerActionType>? actions,
            global::Dataloop.TriggerResourceType? resource)
        {
            this.Input = input;
            this.EndAt = endAt;
            this.StartAt = startAt;
            this.Cron = cron;
            this.Operation = operation;
            this.Filter = filter;
            this.ExecutionMode = executionMode;
            this.Actions = actions;
            this.Resource = resource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ITriggerSpecSpec" /> class.
        /// </summary>
        public ITriggerSpecSpec()
        {
        }
    }
}