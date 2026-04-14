
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkComponentService
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mandatory")]
        public bool? Mandatory { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public global::Dataloop.ServiceRuntime? Runtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initParams")]
        public global::Dataloop.Dictionary? InitParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleName")]
        public string? ModuleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panelNames")]
        public global::System.Collections.Generic.IList<string>? PanelNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botUserName")]
        public string? BotUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAttempts")]
        public double? MaxAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useUserJwt")]
        public bool? UseUserJwt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.ServiceMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::Dataloop.JsServiceVersions? Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<string>? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelOperation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ModelOperationTypesJsonConverter))]
        public global::Dataloop.ModelOperationTypes? ModelOperation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EComponentServiceOperationJsonConverter))]
        public global::Dataloop.EComponentServiceOperation? Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computeConfig")]
        public string? ComputeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? Integrations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::Dataloop.Dictionary? App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentService" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mandatory"></param>
        /// <param name="runExecutionAsProcess"></param>
        /// <param name="executionTimeout"></param>
        /// <param name="drainTime"></param>
        /// <param name="onReset"></param>
        /// <param name="runtime"></param>
        /// <param name="initParams"></param>
        /// <param name="moduleName"></param>
        /// <param name="panelNames"></param>
        /// <param name="botUserName"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="useUserJwt"></param>
        /// <param name="metadata"></param>
        /// <param name="versions"></param>
        /// <param name="secrets"></param>
        /// <param name="driverId"></param>
        /// <param name="modelOperation"></param>
        /// <param name="operation"></param>
        /// <param name="computeConfig"></param>
        /// <param name="integrations"></param>
        /// <param name="app"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkComponentService(
            string name,
            bool? mandatory,
            bool? runExecutionAsProcess,
            double? executionTimeout,
            double? drainTime,
            global::Dataloop.OnResetAction? onReset,
            global::Dataloop.ServiceRuntime? runtime,
            global::Dataloop.Dictionary? initParams,
            string? moduleName,
            global::System.Collections.Generic.IList<string>? panelNames,
            string? botUserName,
            double? maxAttempts,
            bool? useUserJwt,
            global::Dataloop.ServiceMetadata? metadata,
            global::Dataloop.JsServiceVersions? versions,
            global::System.Collections.Generic.IList<string>? secrets,
            string? driverId,
            global::Dataloop.ModelOperationTypes? modelOperation,
            global::Dataloop.EComponentServiceOperation? operation,
            string? computeConfig,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? integrations,
            global::Dataloop.Dictionary? app)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Mandatory = mandatory;
            this.RunExecutionAsProcess = runExecutionAsProcess;
            this.ExecutionTimeout = executionTimeout;
            this.DrainTime = drainTime;
            this.OnReset = onReset;
            this.Runtime = runtime;
            this.InitParams = initParams;
            this.ModuleName = moduleName;
            this.PanelNames = panelNames;
            this.BotUserName = botUserName;
            this.MaxAttempts = maxAttempts;
            this.UseUserJwt = useUserJwt;
            this.Metadata = metadata;
            this.Versions = versions;
            this.Secrets = secrets;
            this.DriverId = driverId;
            this.ModelOperation = modelOperation;
            this.Operation = operation;
            this.ComputeConfig = computeConfig;
            this.Integrations = integrations;
            this.App = app;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentService" /> class.
        /// </summary>
        public IDpkComponentService()
        {
        }
    }
}