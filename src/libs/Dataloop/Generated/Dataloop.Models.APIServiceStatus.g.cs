
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIServiceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numMessagesInQueue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumMessagesInQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtimeStatus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.ServiceRuntimeStatus> RuntimeStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIServiceStatus" /> class.
        /// </summary>
        /// <param name="numMessagesInQueue"></param>
        /// <param name="runtimeStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIServiceStatus(
            double numMessagesInQueue,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceRuntimeStatus> runtimeStatus)
        {
            this.NumMessagesInQueue = numMessagesInQueue;
            this.RuntimeStatus = runtimeStatus ?? throw new global::System.ArgumentNullException(nameof(runtimeStatus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIServiceStatus" /> class.
        /// </summary>
        public APIServiceStatus()
        {
        }
    }
}