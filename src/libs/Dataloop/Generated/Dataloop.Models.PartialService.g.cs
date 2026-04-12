
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialService
    {
        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageId")]
        public string? PackageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        public string? OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgName")]
        public string? OrgName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageRevision")]
        public string? PackageRevision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initParams")]
        public object? InitParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public global::Dataloop.ServiceRuntime? Runtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useUserJwt")]
        public bool? UseUserJwt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botUserName")]
        public string? BotUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::Dataloop.ServiceVersions? Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleName")]
        public string? ModuleName { get; set; }

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
        public bool? RunExecutionAsProcess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionTimeout")]
        public double? ExecutionTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drainTime")]
        public double? DrainTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onReset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.OnResetActionJsonConverter))]
        public global::Dataloop.OnResetAction? OnReset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textSearch")]
        public global::Dataloop.TextSearch? TextSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mq")]
        public global::Dataloop.MqDetails? Mq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("idInDriver")]
        public string? IdInDriver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<string>? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAttempts")]
        public double? MaxAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mqUsername")]
        public string? MqUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authz")]
        public global::Dataloop.AuthZBlockServiceContext? Authz { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        public string? AppId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyUpdatedAt")]
        public global::System.DateTime? ConcurrencyUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialService" /> class.
        /// </summary>
        /// <param name="packageId">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="orgId"></param>
        /// <param name="orgName"></param>
        /// <param name="packageRevision"></param>
        /// <param name="initParams"></param>
        /// <param name="runtime"></param>
        /// <param name="useUserJwt"></param>
        /// <param name="botUserName"></param>
        /// <param name="versions"></param>
        /// <param name="moduleName"></param>
        /// <param name="global"></param>
        /// <param name="active"></param>
        /// <param name="runExecutionAsProcess"></param>
        /// <param name="executionTimeout"></param>
        /// <param name="drainTime"></param>
        /// <param name="onReset"></param>
        /// <param name="name"></param>
        /// <param name="textSearch"></param>
        /// <param name="projectId"></param>
        /// <param name="driverId"></param>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="mq"></param>
        /// <param name="version"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="idInDriver"></param>
        /// <param name="secrets"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="mqUsername"></param>
        /// <param name="authz"></param>
        /// <param name="panels"></param>
        /// <param name="config"></param>
        /// <param name="type"></param>
        /// <param name="appId"></param>
        /// <param name="crashloop"></param>
        /// <param name="mode"></param>
        /// <param name="metadata"></param>
        /// <param name="updatedBy"></param>
        /// <param name="archive"></param>
        /// <param name="settings"></param>
        /// <param name="displayName"></param>
        /// <param name="app"></param>
        /// <param name="integrations"></param>
        /// <param name="concurrencyUpdatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialService(
            string? packageId,
            string? orgId,
            string? orgName,
            string? packageRevision,
            object? initParams,
            global::Dataloop.ServiceRuntime? runtime,
            bool? useUserJwt,
            string? botUserName,
            global::Dataloop.ServiceVersions? versions,
            string? moduleName,
            bool? global,
            bool? active,
            bool? runExecutionAsProcess,
            double? executionTimeout,
            double? drainTime,
            global::Dataloop.OnResetAction? onReset,
            string? name,
            global::Dataloop.TextSearch? textSearch,
            string? projectId,
            string? driverId,
            string? id,
            global::Dataloop.MqDetails? mq,
            string? version,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? creator,
            string? idInDriver,
            global::System.Collections.Generic.IList<string>? secrets,
            double? maxAttempts,
            string? mqUsername,
            global::Dataloop.AuthZBlockServiceContext? authz,
            global::System.Collections.Generic.IList<global::Dataloop.Panel>? panels,
            global::Dataloop.IServiceAppConfig? config,
            global::Dataloop.ServiceType? type,
            string? appId,
            global::Dataloop.Crashloop? crashloop,
            global::Dataloop.ServiceMode? mode,
            global::Dataloop.ServiceMetadata? metadata,
            string? updatedBy,
            bool? archive,
            global::Dataloop.IServiceGeneralSettings? settings,
            string? displayName,
            global::Dataloop.IAppDefinition? app,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? integrations,
            global::System.DateTime? concurrencyUpdatedAt)
        {
            this.PackageId = packageId;
            this.OrgId = orgId;
            this.OrgName = orgName;
            this.PackageRevision = packageRevision;
            this.InitParams = initParams;
            this.Runtime = runtime;
            this.UseUserJwt = useUserJwt;
            this.BotUserName = botUserName;
            this.Versions = versions;
            this.ModuleName = moduleName;
            this.Global = global;
            this.Active = active;
            this.RunExecutionAsProcess = runExecutionAsProcess;
            this.ExecutionTimeout = executionTimeout;
            this.DrainTime = drainTime;
            this.OnReset = onReset;
            this.Name = name;
            this.TextSearch = textSearch;
            this.ProjectId = projectId;
            this.DriverId = driverId;
            this.Id = id;
            this.Mq = mq;
            this.Version = version;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Creator = creator;
            this.IdInDriver = idInDriver;
            this.Secrets = secrets;
            this.MaxAttempts = maxAttempts;
            this.MqUsername = mqUsername;
            this.Authz = authz;
            this.Panels = panels;
            this.Config = config;
            this.Type = type;
            this.AppId = appId;
            this.Crashloop = crashloop;
            this.Mode = mode;
            this.Metadata = metadata;
            this.UpdatedBy = updatedBy;
            this.Archive = archive;
            this.Settings = settings;
            this.DisplayName = displayName;
            this.App = app;
            this.Integrations = integrations;
            this.ConcurrencyUpdatedAt = concurrencyUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialService" /> class.
        /// </summary>
        public PartialService()
        {
        }
    }
}