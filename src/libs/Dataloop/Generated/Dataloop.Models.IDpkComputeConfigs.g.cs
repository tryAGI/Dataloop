
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkComputeConfigs
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
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::Dataloop.JsServiceVersions? Versions { get; set; }

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
        /// Initializes a new instance of the <see cref="IDpkComputeConfigs" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mandatory"></param>
        /// <param name="runExecutionAsProcess"></param>
        /// <param name="executionTimeout"></param>
        /// <param name="drainTime"></param>
        /// <param name="onReset"></param>
        /// <param name="runtime"></param>
        /// <param name="botUserName"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="useUserJwt"></param>
        /// <param name="driverId"></param>
        /// <param name="versions"></param>
        /// <param name="integrations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkComputeConfigs(
            string name,
            bool? mandatory,
            bool? runExecutionAsProcess,
            double? executionTimeout,
            double? drainTime,
            global::Dataloop.OnResetAction? onReset,
            global::Dataloop.ServiceRuntime? runtime,
            string? botUserName,
            double? maxAttempts,
            bool? useUserJwt,
            string? driverId,
            global::Dataloop.JsServiceVersions? versions,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? integrations)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Mandatory = mandatory;
            this.RunExecutionAsProcess = runExecutionAsProcess;
            this.ExecutionTimeout = executionTimeout;
            this.DrainTime = drainTime;
            this.OnReset = onReset;
            this.Runtime = runtime;
            this.BotUserName = botUserName;
            this.MaxAttempts = maxAttempts;
            this.UseUserJwt = useUserJwt;
            this.DriverId = driverId;
            this.Versions = versions;
            this.Integrations = integrations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComputeConfigs" /> class.
        /// </summary>
        public IDpkComputeConfigs()
        {
        }
    }
}