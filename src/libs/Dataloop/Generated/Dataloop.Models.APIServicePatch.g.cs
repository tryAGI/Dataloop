
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIServicePatch
    {
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
        public string? OnReset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAttempts")]
        public double? MaxAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botUserName")]
        public string? BotUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<string>? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ServiceTypeJsonConverter))]
        public global::Dataloop.ServiceType? Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("panels")]
        public global::System.Collections.Generic.IList<global::Dataloop.Panel>? Panels { get; set; }

        /// <summary>
        /// 
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
        [global::System.Text.Json.Serialization.JsonPropertyName("archive")]
        public bool? Archive { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIServicePatch" /> class.
        /// </summary>
        /// <param name="packageRevision"></param>
        /// <param name="initParams"></param>
        /// <param name="runtime"></param>
        /// <param name="useUserJwt"></param>
        /// <param name="versions"></param>
        /// <param name="moduleName"></param>
        /// <param name="global"></param>
        /// <param name="active"></param>
        /// <param name="runExecutionAsProcess"></param>
        /// <param name="executionTimeout"></param>
        /// <param name="drainTime"></param>
        /// <param name="onReset"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="version"></param>
        /// <param name="botUserName"></param>
        /// <param name="driverId"></param>
        /// <param name="secrets"></param>
        /// <param name="type"></param>
        /// <param name="mode"></param>
        /// <param name="metadata"></param>
        /// <param name="panels"></param>
        /// <param name="packageId"></param>
        /// <param name="packageName"></param>
        /// <param name="archive"></param>
        /// <param name="displayName"></param>
        /// <param name="app"></param>
        /// <param name="integrations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIServicePatch(
            string? packageRevision,
            object? initParams,
            global::Dataloop.ServiceRuntime? runtime,
            bool? useUserJwt,
            global::Dataloop.ServiceVersions? versions,
            string? moduleName,
            bool? global,
            bool? active,
            bool? runExecutionAsProcess,
            double? executionTimeout,
            double? drainTime,
            string? onReset,
            double? maxAttempts,
            string? version,
            string? botUserName,
            string? driverId,
            global::System.Collections.Generic.IList<string>? secrets,
            global::Dataloop.ServiceType? type,
            global::Dataloop.ServiceMode? mode,
            global::Dataloop.ServiceMetadata? metadata,
            global::System.Collections.Generic.IList<global::Dataloop.Panel>? panels,
            string? packageId,
            string? packageName,
            bool? archive,
            string? displayName,
            global::Dataloop.IAppDefinition? app,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? integrations)
        {
            this.PackageRevision = packageRevision;
            this.InitParams = initParams;
            this.Runtime = runtime;
            this.UseUserJwt = useUserJwt;
            this.Versions = versions;
            this.ModuleName = moduleName;
            this.Global = global;
            this.Active = active;
            this.RunExecutionAsProcess = runExecutionAsProcess;
            this.ExecutionTimeout = executionTimeout;
            this.DrainTime = drainTime;
            this.OnReset = onReset;
            this.MaxAttempts = maxAttempts;
            this.Version = version;
            this.BotUserName = botUserName;
            this.DriverId = driverId;
            this.Secrets = secrets;
            this.Type = type;
            this.Mode = mode;
            this.Metadata = metadata;
            this.Panels = panels;
            this.PackageId = packageId;
            this.PackageName = packageName;
            this.Archive = archive;
            this.DisplayName = displayName;
            this.App = app;
            this.Integrations = integrations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIServicePatch" /> class.
        /// </summary>
        public APIServicePatch()
        {
        }
    }
}