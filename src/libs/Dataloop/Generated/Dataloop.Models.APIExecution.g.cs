
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIExecution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerId")]
        public string? TriggerId { get; set; }

        /// <summary>
        /// The service name where the execution was executed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        public string? ServiceName { get; set; }

        /// <summary>
        /// The module containing the function code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleName")]
        public string? ModuleName { get; set; }

        /// <summary>
        /// 
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
        public global::Dataloop.IPipelineExecution? Pipeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Dataloop.ExecutionModel? Model { get; set; }

        /// <summary>
        /// Used when running execution in sync mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syncReplyTo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIExecutionSyncReplyTo SyncReplyTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventContext")]
        public global::Dataloop.ExecutionEventContext? EventContext { get; set; }

        /// <summary>
        /// Archive the service after the execution is done (mode = ExecutionMode.ONCE)
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIExecution" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="attempts"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="toTerminate"></param>
        /// <param name="input"></param>
        /// <param name="status"></param>
        /// <param name="statusLog"></param>
        /// <param name="latestStatus"></param>
        /// <param name="duration"></param>
        /// <param name="projectId"></param>
        /// <param name="serviceId"></param>
        /// <param name="packageId"></param>
        /// <param name="packageName"></param>
        /// <param name="packageRevision"></param>
        /// <param name="serviceVersion"></param>
        /// <param name="syncReplyTo">
        /// Used when running execution in sync mode
        /// </param>
        /// <param name="output"></param>
        /// <param name="functionName"></param>
        /// <param name="triggerId"></param>
        /// <param name="serviceName">
        /// The service name where the execution was executed
        /// </param>
        /// <param name="moduleName">
        /// The module containing the function code
        /// </param>
        /// <param name="pipeline"></param>
        /// <param name="model"></param>
        /// <param name="eventContext"></param>
        /// <param name="archiveService">
        /// Archive the service after the execution is done (mode = ExecutionMode.ONCE)
        /// </param>
        /// <param name="app"></param>
        /// <param name="driverId"></param>
        /// <param name="hook"></param>
        /// <param name="timeoutSeconds"></param>
        /// <param name="deadline"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIExecution(
            string id,
            string url,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string creator,
            double attempts,
            double maxAttempts,
            bool toTerminate,
            global::Dataloop.Dictionary input,
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
            global::Dataloop.APIExecutionSyncReplyTo syncReplyTo,
            global::Dataloop.Dictionary? output,
            string? functionName,
            string? triggerId,
            string? serviceName,
            string? moduleName,
            global::Dataloop.IPipelineExecution? pipeline,
            global::Dataloop.ExecutionModel? model,
            global::Dataloop.ExecutionEventContext? eventContext,
            bool? archiveService,
            global::Dataloop.IAppDefinition? app,
            string? driverId,
            global::Dataloop.ExecutionHook? hook,
            double? timeoutSeconds,
            global::System.DateTime? deadline)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Attempts = attempts;
            this.MaxAttempts = maxAttempts;
            this.ToTerminate = toTerminate;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Output = output;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StatusLog = statusLog ?? throw new global::System.ArgumentNullException(nameof(statusLog));
            this.LatestStatus = latestStatus ?? throw new global::System.ArgumentNullException(nameof(latestStatus));
            this.Duration = duration;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.FunctionName = functionName;
            this.ServiceId = serviceId ?? throw new global::System.ArgumentNullException(nameof(serviceId));
            this.TriggerId = triggerId;
            this.ServiceName = serviceName;
            this.ModuleName = moduleName;
            this.PackageId = packageId ?? throw new global::System.ArgumentNullException(nameof(packageId));
            this.PackageName = packageName ?? throw new global::System.ArgumentNullException(nameof(packageName));
            this.PackageRevision = packageRevision;
            this.ServiceVersion = serviceVersion;
            this.Pipeline = pipeline;
            this.Model = model;
            this.SyncReplyTo = syncReplyTo ?? throw new global::System.ArgumentNullException(nameof(syncReplyTo));
            this.EventContext = eventContext;
            this.ArchiveService = archiveService;
            this.App = app;
            this.DriverId = driverId;
            this.Hook = hook;
            this.TimeoutSeconds = timeoutSeconds;
            this.Deadline = deadline;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIExecution" /> class.
        /// </summary>
        public APIExecution()
        {
        }
    }
}