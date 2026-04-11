
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DebugSession
    {
        /// <summary>
        /// Server-only: set after first successful debug ingress create (ACTIVATE may poll frequently)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serveDebugIngressCreated")]
        public bool? ServeDebugIngressCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public global::System.DateTime? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EDebugOptionsStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.EDebugOptionsStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugSession" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="serveDebugIngressCreated">
        /// Server-only: set after first successful debug ingress create (ACTIVATE may poll frequently)
        /// </param>
        /// <param name="time"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DebugSession(
            global::Dataloop.EDebugOptionsStatus status,
            bool? serveDebugIngressCreated,
            global::System.DateTime? time)
        {
            this.ServeDebugIngressCreated = serveDebugIngressCreated;
            this.Time = time;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugSession" /> class.
        /// </summary>
        public DebugSession()
        {
        }
    }
}