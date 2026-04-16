
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICompositionFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public global::Dataloop.ICompositionFilterState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::Dataloop.FilterTarget? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationCode")]
        public string? NotificationCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextMatch")]
        public global::Dataloop.NotificationEventContext? ContextMatch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Frequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.NotificationEntityContext Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationId")]
        public string? NotificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionFilter" /> class.
        /// </summary>
        /// <param name="frequency"></param>
        /// <param name="context"></param>
        /// <param name="state"></param>
        /// <param name="target"></param>
        /// <param name="notificationCode"></param>
        /// <param name="contextMatch"></param>
        /// <param name="notificationId"></param>
        /// <param name="channelId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICompositionFilter(
            global::Dataloop.Dictionary frequency,
            global::Dataloop.NotificationEntityContext context,
            global::Dataloop.ICompositionFilterState? state,
            global::Dataloop.FilterTarget? target,
            string? notificationCode,
            global::Dataloop.NotificationEventContext? contextMatch,
            string? notificationId,
            string? channelId)
        {
            this.State = state;
            this.Target = target;
            this.NotificationCode = notificationCode;
            this.ContextMatch = contextMatch;
            this.Frequency = frequency ?? throw new global::System.ArgumentNullException(nameof(frequency));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.NotificationId = notificationId;
            this.ChannelId = channelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionFilter" /> class.
        /// </summary>
        public ICompositionFilter()
        {
        }
    }
}