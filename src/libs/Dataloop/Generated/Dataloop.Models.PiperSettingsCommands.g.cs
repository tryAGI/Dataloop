
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PiperSettingsCommands
    {
        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentCommandId")]
        public string? ParentCommandId { get; set; }

        /// <summary>
        /// Number of times execution attempted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visitedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double VisitedCount { get; set; }

        /// <summary>
        /// type of the command to process as string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Number of child commands
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("childsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ChildsCount { get; set; }

        /// <summary>
        /// Number of child commands persisted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persistedChildsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PersistedChildsCount { get; set; }

        /// <summary>
        /// Number of child commands dispatched for execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dispatchedChildsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DispatchedChildsCount { get; set; }

        /// <summary>
        /// Estimated child commands count
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("childsEstimationCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ChildsEstimationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        public global::Dataloop.Dictionary? Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Dataloop.CommandError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CommandStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CommandStatus Status { get; set; }

        /// <summary>
        /// Command status log
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusHistory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.CommandStatusHistoryEntry> StatusHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trackingInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.PiperSettingsCommandsTrackingInfo TrackingInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ctx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CommandCtx Ctx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("childrenProgress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ChildrenCommandsProgress ChildrenProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CommandsDomainJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CommandsDomain Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report")]
        public global::Dataloop.Dictionary? Report { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry")]
        public global::Dataloop.PiperSettingsCommandsRetry? Retry { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PiperSettingsCommands" /> class.
        /// </summary>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="visitedCount">
        /// Number of times execution attempted
        /// </param>
        /// <param name="type">
        /// type of the command to process as string
        /// </param>
        /// <param name="childsCount">
        /// Number of child commands
        /// </param>
        /// <param name="persistedChildsCount">
        /// Number of child commands persisted
        /// </param>
        /// <param name="dispatchedChildsCount">
        /// Number of child commands dispatched for execution
        /// </param>
        /// <param name="childsEstimationCount">
        /// Estimated child commands count
        /// </param>
        /// <param name="status"></param>
        /// <param name="statusHistory">
        /// Command status log
        /// </param>
        /// <param name="trackingInfo"></param>
        /// <param name="ctx"></param>
        /// <param name="childrenProgress"></param>
        /// <param name="domain"></param>
        /// <param name="updatedAt"></param>
        /// <param name="parentCommandId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="spec"></param>
        /// <param name="priority"></param>
        /// <param name="error"></param>
        /// <param name="report"></param>
        /// <param name="retry"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PiperSettingsCommands(
            string id,
            global::System.DateTime createdAt,
            double visitedCount,
            string type,
            double childsCount,
            double persistedChildsCount,
            double dispatchedChildsCount,
            double childsEstimationCount,
            global::Dataloop.CommandStatus status,
            global::System.Collections.Generic.IList<global::Dataloop.CommandStatusHistoryEntry> statusHistory,
            global::Dataloop.PiperSettingsCommandsTrackingInfo trackingInfo,
            global::Dataloop.CommandCtx ctx,
            global::Dataloop.ChildrenCommandsProgress childrenProgress,
            global::Dataloop.CommandsDomain domain,
            global::System.DateTime? updatedAt,
            string? parentCommandId,
            global::Dataloop.Dictionary? spec,
            double? priority,
            global::Dataloop.CommandError? error,
            global::Dataloop.Dictionary? report,
            global::Dataloop.PiperSettingsCommandsRetry? retry)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ParentCommandId = parentCommandId;
            this.VisitedCount = visitedCount;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ChildsCount = childsCount;
            this.PersistedChildsCount = persistedChildsCount;
            this.DispatchedChildsCount = dispatchedChildsCount;
            this.ChildsEstimationCount = childsEstimationCount;
            this.Spec = spec;
            this.Priority = priority;
            this.Error = error;
            this.Status = status;
            this.StatusHistory = statusHistory ?? throw new global::System.ArgumentNullException(nameof(statusHistory));
            this.TrackingInfo = trackingInfo ?? throw new global::System.ArgumentNullException(nameof(trackingInfo));
            this.Ctx = ctx ?? throw new global::System.ArgumentNullException(nameof(ctx));
            this.ChildrenProgress = childrenProgress ?? throw new global::System.ArgumentNullException(nameof(childrenProgress));
            this.Domain = domain;
            this.Report = report;
            this.Retry = retry;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiperSettingsCommands" /> class.
        /// </summary>
        public PiperSettingsCommands()
        {
        }
    }
}