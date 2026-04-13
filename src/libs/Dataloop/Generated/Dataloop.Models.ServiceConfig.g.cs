
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceConfig
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("onReset")]
        public string? OnReset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceConfig" /> class.
        /// </summary>
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
        /// <param name="onReset"></param>
        /// <param name="name"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="secrets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceConfig(
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
            string? onReset,
            string? name,
            double? maxAttempts,
            global::System.Collections.Generic.IList<string>? secrets)
        {
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
            this.OnReset = onReset;
            this.Name = name;
            this.MaxAttempts = maxAttempts;
            this.Secrets = secrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceConfig" /> class.
        /// </summary>
        public ServiceConfig()
        {
        }
    }
}