
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIServiceCompositionElement
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
        [global::System.Text.Json.Serialization.JsonPropertyName("packageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        public string? AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageRevision")]
        public string? PackageRevision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initParams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InitParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ServiceRuntime Runtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useUserJwt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UseUserJwt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botUserName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BotUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ServiceVersions Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModuleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        public bool? Global { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runExecutionAsProcess")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RunExecutionAsProcess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionTimeout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExecutionTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drainTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DrainTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onReset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.OnResetActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.OnResetAction OnReset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAttempts")]
        public double? MaxAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<string>? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panels")]
        public global::System.Collections.Generic.IList<global::Dataloop.Panel>? Panels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Dataloop.IServiceAppConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ServiceTypeJsonConverter))]
        public global::Dataloop.ServiceType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crashloop")]
        public global::Dataloop.Crashloop? Crashloop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public global::Dataloop.ServiceMode? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.ServiceMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive")]
        public bool? Archive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Dataloop.IServiceGeneralSettings? Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::Dataloop.IAppDefinition? App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? Integrations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        public string? OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIServiceCompositionElementState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageName")]
        public string? PackageName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uiHooks")]
        public global::System.Collections.Generic.IList<object>? UiHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shareable")]
        public bool? Shareable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIServiceCompositionElement" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="packageId"></param>
        /// <param name="initParams"></param>
        /// <param name="runtime"></param>
        /// <param name="useUserJwt"></param>
        /// <param name="botUserName"></param>
        /// <param name="versions"></param>
        /// <param name="moduleName"></param>
        /// <param name="runExecutionAsProcess"></param>
        /// <param name="executionTimeout"></param>
        /// <param name="drainTime"></param>
        /// <param name="onReset"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="driverId"></param>
        /// <param name="version"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="state"></param>
        /// <param name="appId"></param>
        /// <param name="packageRevision"></param>
        /// <param name="global"></param>
        /// <param name="active"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="secrets"></param>
        /// <param name="panels"></param>
        /// <param name="config"></param>
        /// <param name="type"></param>
        /// <param name="crashloop"></param>
        /// <param name="mode"></param>
        /// <param name="metadata"></param>
        /// <param name="updatedBy"></param>
        /// <param name="archive"></param>
        /// <param name="settings"></param>
        /// <param name="displayName"></param>
        /// <param name="app"></param>
        /// <param name="integrations"></param>
        /// <param name="orgId"></param>
        /// <param name="packageName"></param>
        /// <param name="uiHooks"></param>
        /// <param name="shareable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIServiceCompositionElement(
            string id,
            string url,
            string packageId,
            object initParams,
            global::Dataloop.ServiceRuntime runtime,
            bool useUserJwt,
            string botUserName,
            global::Dataloop.ServiceVersions versions,
            string moduleName,
            bool runExecutionAsProcess,
            double executionTimeout,
            double drainTime,
            global::Dataloop.OnResetAction onReset,
            string name,
            string projectId,
            string driverId,
            string version,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string creator,
            global::Dataloop.APIServiceCompositionElementState state,
            string? appId,
            string? packageRevision,
            bool? global,
            bool? active,
            double? maxAttempts,
            global::System.Collections.Generic.IList<string>? secrets,
            global::System.Collections.Generic.IList<global::Dataloop.Panel>? panels,
            global::Dataloop.IServiceAppConfig? config,
            global::Dataloop.ServiceType? type,
            global::Dataloop.Crashloop? crashloop,
            global::Dataloop.ServiceMode? mode,
            global::Dataloop.ServiceMetadata? metadata,
            string? updatedBy,
            bool? archive,
            global::Dataloop.IServiceGeneralSettings? settings,
            string? displayName,
            global::Dataloop.IAppDefinition? app,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? integrations,
            string? orgId,
            string? packageName,
            global::System.Collections.Generic.IList<object>? uiHooks,
            bool? shareable)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PackageId = packageId ?? throw new global::System.ArgumentNullException(nameof(packageId));
            this.AppId = appId;
            this.PackageRevision = packageRevision;
            this.InitParams = initParams ?? throw new global::System.ArgumentNullException(nameof(initParams));
            this.Runtime = runtime ?? throw new global::System.ArgumentNullException(nameof(runtime));
            this.UseUserJwt = useUserJwt;
            this.BotUserName = botUserName ?? throw new global::System.ArgumentNullException(nameof(botUserName));
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.ModuleName = moduleName ?? throw new global::System.ArgumentNullException(nameof(moduleName));
            this.Global = global;
            this.Active = active;
            this.RunExecutionAsProcess = runExecutionAsProcess;
            this.ExecutionTimeout = executionTimeout;
            this.DrainTime = drainTime;
            this.OnReset = onReset;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DriverId = driverId ?? throw new global::System.ArgumentNullException(nameof(driverId));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.MaxAttempts = maxAttempts;
            this.Secrets = secrets;
            this.Panels = panels;
            this.Config = config;
            this.Type = type;
            this.Crashloop = crashloop;
            this.Mode = mode;
            this.Metadata = metadata;
            this.UpdatedBy = updatedBy;
            this.Archive = archive;
            this.Settings = settings;
            this.DisplayName = displayName;
            this.App = app;
            this.Integrations = integrations;
            this.OrgId = orgId;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.PackageName = packageName;
            this.UiHooks = uiHooks;
            this.Shareable = shareable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIServiceCompositionElement" /> class.
        /// </summary>
        public APIServiceCompositionElement()
        {
        }
    }
}