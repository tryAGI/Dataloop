
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Execution
    {
        /// <summary>
        /// A globally unique identifier for the Entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A local identifier for the Entity, unique within the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The creator of the Entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// The date and time when the Entity was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the Entity was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The user who last updated the Entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Attempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAttempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toTerminate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ToTerminate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Dataloop.Dictionary? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedbackQueue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ExecutionFeedbackQueue FeedbackQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.ExecutionStatusReport> Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusLog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.ExecutionStatusReport> StatusLog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestStatus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ExecutionStatusReport LatestStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionName")]
        public string? FunctionName { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceId { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerId")]
        public string? TriggerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        public string? ServiceName { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageRevision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<double?, string> PackageRevision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<double?, string> ServiceVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        public global::Dataloop.ExecutionPipeline? Pipeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleName")]
        public string? ModuleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Dataloop.ExecutionModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventContext")]
        public global::Dataloop.ExecutionEventContext? EventContext { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authz")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AuthZBlockExecutionContext Authz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        public string? OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        public bool? Global { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Dataloop.ExecutionResource>? Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ExecutionModeJsonConverter))]
        public global::Dataloop.ExecutionMode? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syncReplyTo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ExecutionSyncReplyTo SyncReplyTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archiveService")]
        public bool? ArchiveService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::Dataloop.IAppDefinition? App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ExecutionHook Hook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deadline")]
        public global::System.DateTime? Deadline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiHandleTimeout")]
        public global::System.DateTime? ApiHandleTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ExecutionPhaseJsonConverter))]
        public global::Dataloop.ExecutionPhase? Phase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onReset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.OnResetActionJsonConverter))]
        public global::Dataloop.OnResetAction? OnReset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Execution" /> class.
        /// </summary>
        /// <param name="id">
        /// A globally unique identifier for the Entity.
        /// </param>
        /// <param name="creator">
        /// The creator of the Entity.
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the Entity was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time when the Entity was last updated.
        /// </param>
        /// <param name="attempts"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="toTerminate"></param>
        /// <param name="input"></param>
        /// <param name="feedbackQueue"></param>
        /// <param name="status"></param>
        /// <param name="statusLog"></param>
        /// <param name="latestStatus"></param>
        /// <param name="duration"></param>
        /// <param name="projectId"></param>
        /// <param name="serviceId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="packageId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="packageName"></param>
        /// <param name="packageRevision"></param>
        /// <param name="serviceVersion"></param>
        /// <param name="id2">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="authz"></param>
        /// <param name="syncReplyTo"></param>
        /// <param name="hook"></param>
        /// <param name="clientId">
        /// A local identifier for the Entity, unique within the client.
        /// </param>
        /// <param name="updatedBy">
        /// The user who last updated the Entity.
        /// </param>
        /// <param name="output"></param>
        /// <param name="functionName"></param>
        /// <param name="triggerId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="serviceName"></param>
        /// <param name="pipeline"></param>
        /// <param name="moduleName"></param>
        /// <param name="model"></param>
        /// <param name="eventContext"></param>
        /// <param name="orgId"></param>
        /// <param name="global"></param>
        /// <param name="resources"></param>
        /// <param name="mode"></param>
        /// <param name="archiveService"></param>
        /// <param name="app"></param>
        /// <param name="driverId"></param>
        /// <param name="timeoutSeconds"></param>
        /// <param name="deadline"></param>
        /// <param name="apiHandleTimeout"></param>
        /// <param name="phase"></param>
        /// <param name="onReset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Execution(
            string id,
            string creator,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            double attempts,
            double maxAttempts,
            bool toTerminate,
            global::Dataloop.Dictionary input,
            global::Dataloop.ExecutionFeedbackQueue feedbackQueue,
            global::System.Collections.Generic.IList<global::Dataloop.ExecutionStatusReport> status,
            global::System.Collections.Generic.IList<global::Dataloop.ExecutionStatusReport> statusLog,
            global::Dataloop.ExecutionStatusReport latestStatus,
            double duration,
            string projectId,
            string serviceId,
            string packageId,
            string packageName,
            global::Dataloop.AnyOf<double?, string> packageRevision,
            global::Dataloop.AnyOf<double?, string> serviceVersion,
            string id2,
            global::Dataloop.AuthZBlockExecutionContext authz,
            global::Dataloop.ExecutionSyncReplyTo syncReplyTo,
            global::Dataloop.ExecutionHook hook,
            string? clientId,
            string? updatedBy,
            global::Dataloop.Dictionary? output,
            string? functionName,
            string? triggerId,
            string? serviceName,
            global::Dataloop.ExecutionPipeline? pipeline,
            string? moduleName,
            global::Dataloop.ExecutionModel? model,
            global::Dataloop.ExecutionEventContext? eventContext,
            string? orgId,
            bool? global,
            global::System.Collections.Generic.IList<global::Dataloop.ExecutionResource>? resources,
            global::Dataloop.ExecutionMode? mode,
            bool? archiveService,
            global::Dataloop.IAppDefinition? app,
            string? driverId,
            double? timeoutSeconds,
            global::System.DateTime? deadline,
            global::System.DateTime? apiHandleTimeout,
            global::Dataloop.ExecutionPhase? phase,
            global::Dataloop.OnResetAction? onReset)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ClientId = clientId;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Attempts = attempts;
            this.MaxAttempts = maxAttempts;
            this.ToTerminate = toTerminate;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Output = output;
            this.FeedbackQueue = feedbackQueue ?? throw new global::System.ArgumentNullException(nameof(feedbackQueue));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StatusLog = statusLog ?? throw new global::System.ArgumentNullException(nameof(statusLog));
            this.LatestStatus = latestStatus ?? throw new global::System.ArgumentNullException(nameof(latestStatus));
            this.Duration = duration;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.FunctionName = functionName;
            this.ServiceId = serviceId ?? throw new global::System.ArgumentNullException(nameof(serviceId));
            this.TriggerId = triggerId;
            this.ServiceName = serviceName;
            this.PackageId = packageId ?? throw new global::System.ArgumentNullException(nameof(packageId));
            this.PackageName = packageName ?? throw new global::System.ArgumentNullException(nameof(packageName));
            this.PackageRevision = packageRevision;
            this.ServiceVersion = serviceVersion;
            this.Pipeline = pipeline;
            this.ModuleName = moduleName;
            this.Model = model;
            this.EventContext = eventContext;
            this.Id2 = id2 ?? throw new global::System.ArgumentNullException(nameof(id2));
            this.Authz = authz ?? throw new global::System.ArgumentNullException(nameof(authz));
            this.OrgId = orgId;
            this.Global = global;
            this.Resources = resources;
            this.Mode = mode;
            this.SyncReplyTo = syncReplyTo ?? throw new global::System.ArgumentNullException(nameof(syncReplyTo));
            this.ArchiveService = archiveService;
            this.App = app;
            this.DriverId = driverId;
            this.Hook = hook ?? throw new global::System.ArgumentNullException(nameof(hook));
            this.TimeoutSeconds = timeoutSeconds;
            this.Deadline = deadline;
            this.ApiHandleTimeout = apiHandleTimeout;
            this.Phase = phase;
            this.OnReset = onReset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Execution" /> class.
        /// </summary>
        public Execution()
        {
        }
    }
}