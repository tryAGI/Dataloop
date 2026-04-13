
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Crashloop
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CrashloopActionJsonConverter))]
        public global::Dataloop.CrashloopAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CrashloopReasonJsonConverter))]
        public global::Dataloop.CrashloopReason? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Crashloop" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="action"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Crashloop(
            global::System.DateTime time,
            global::Dataloop.CrashloopAction action,
            global::Dataloop.CrashloopReason? reason)
        {
            this.Time = time;
            this.Action = action;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Crashloop" /> class.
        /// </summary>
        public Crashloop()
        {
        }
    }
}