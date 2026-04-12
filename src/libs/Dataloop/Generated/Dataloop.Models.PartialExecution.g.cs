
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialExecution
    {
        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        public double? Attempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAttempts")]
        public double? MaxAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toTerminate")]
        public bool? ToTerminate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::Dataloop.Dictionary? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Dataloop.Dictionary? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusLog")]
        public global::System.Collections.Generic.IList<global::Dataloop.ExecutionStatusReport>? StatusLog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionName")]
        public string? FunctionName { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceId")]
        public string? ServiceId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleName")]
        public string? ModuleName { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageId")]
        public string? PackageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageName")]
        public string? PackageName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageRevision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>))]
        public global::Dataloop.AnyOf<string, double?>? PackageRevision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>))]
        public global::Dataloop.AnyOf<string, double?>? ServiceVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        public global::Dataloop.IPipelineExecution? Pipeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Dataloop.ExecutionModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authz")]
        public global::Dataloop.AuthZBlockExecutionContext? Authz { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("eventContext")]
        public global::Dataloop.ExecutionEventContext? EventContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ExecutionModeJsonConverter))]
        public global::Dataloop.ExecutionMode? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestStatus")]
        public global::Dataloop.ExecutionStatusReport? LatestStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syncReplyTo")]
        public global::Dataloop.PartialExecutionSyncReplyTo? SyncReplyTo { get; set; }

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
        public global::Dataloop.ExecutionHook? Hook { get; set; }

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
        /// Initializes a new instance of the <see cref="PartialExecution" /> class.
        /// </summary>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="attempts"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="toTerminate"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="statusLog"></param>
        /// <param name="duration"></param>
        /// <param name="projectId"></param>
        /// <param name="functionName"></param>
        /// <param name="serviceId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="triggerId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="serviceName"></param>
        /// <param name="moduleName"></param>
        /// <param name="packageId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="packageName"></param>
        /// <param name="packageRevision"></param>
        /// <param name="serviceVersion"></param>
        /// <param name="pipeline"></param>
        /// <param name="model"></param>
        /// <param name="authz"></param>
        /// <param name="orgId"></param>
        /// <param name="global"></param>
        /// <param name="resources"></param>
        /// <param name="eventContext"></param>
        /// <param name="mode"></param>
        /// <param name="latestStatus"></param>
        /// <param name="syncReplyTo"></param>
        /// <param name="archiveService"></param>
        /// <param name="app"></param>
        /// <param name="driverId"></param>
        /// <param name="hook"></param>
        /// <param name="timeoutSeconds"></param>
        /// <param name="deadline"></param>
        /// <param name="apiHandleTimeout"></param>
        /// <param name="phase"></param>
        /// <param name="onReset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialExecution(
            string? id,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? creator,
            double? attempts,
            double? maxAttempts,
            bool? toTerminate,
            global::Dataloop.Dictionary? input,
            global::Dataloop.Dictionary? output,
            global::System.Collections.Generic.IList<global::Dataloop.ExecutionStatusReport>? statusLog,
            double? duration,
            string? projectId,
            string? functionName,
            string? serviceId,
            string? triggerId,
            string? serviceName,
            string? moduleName,
            string? packageId,
            string? packageName,
            global::Dataloop.AnyOf<string, double?>? packageRevision,
            global::Dataloop.AnyOf<string, double?>? serviceVersion,
            global::Dataloop.IPipelineExecution? pipeline,
            global::Dataloop.ExecutionModel? model,
            global::Dataloop.AuthZBlockExecutionContext? authz,
            string? orgId,
            bool? global,
            global::System.Collections.Generic.IList<global::Dataloop.ExecutionResource>? resources,
            global::Dataloop.ExecutionEventContext? eventContext,
            global::Dataloop.ExecutionMode? mode,
            global::Dataloop.ExecutionStatusReport? latestStatus,
            global::Dataloop.PartialExecutionSyncReplyTo? syncReplyTo,
            bool? archiveService,
            global::Dataloop.IAppDefinition? app,
            string? driverId,
            global::Dataloop.ExecutionHook? hook,
            double? timeoutSeconds,
            global::System.DateTime? deadline,
            global::System.DateTime? apiHandleTimeout,
            global::Dataloop.ExecutionPhase? phase,
            global::Dataloop.OnResetAction? onReset)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Creator = creator;
            this.Attempts = attempts;
            this.MaxAttempts = maxAttempts;
            this.ToTerminate = toTerminate;
            this.Input = input;
            this.Output = output;
            this.StatusLog = statusLog;
            this.Duration = duration;
            this.ProjectId = projectId;
            this.FunctionName = functionName;
            this.ServiceId = serviceId;
            this.TriggerId = triggerId;
            this.ServiceName = serviceName;
            this.ModuleName = moduleName;
            this.PackageId = packageId;
            this.PackageName = packageName;
            this.PackageRevision = packageRevision;
            this.ServiceVersion = serviceVersion;
            this.Pipeline = pipeline;
            this.Model = model;
            this.Authz = authz;
            this.OrgId = orgId;
            this.Global = global;
            this.Resources = resources;
            this.EventContext = eventContext;
            this.Mode = mode;
            this.LatestStatus = latestStatus;
            this.SyncReplyTo = syncReplyTo;
            this.ArchiveService = archiveService;
            this.App = app;
            this.DriverId = driverId;
            this.Hook = hook;
            this.TimeoutSeconds = timeoutSeconds;
            this.Deadline = deadline;
            this.ApiHandleTimeout = apiHandleTimeout;
            this.Phase = phase;
            this.OnReset = onReset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialExecution" /> class.
        /// </summary>
        public PartialExecution()
        {
        }
    }
}