
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkComponentModule
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
        [global::System.Text.Json.Serialization.JsonPropertyName("entryPoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntryPoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("className")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initInputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.PackageIO> InitInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.DLFunction> Functions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mandatory")]
        public bool? Mandatory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::Dataloop.JsServiceVersions? Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Dataloop.IServiceAppConfig? Config { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceConfig")]
        public global::Dataloop.PartialService? ServiceConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computeConfig")]
        public string? ComputeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<string>? Integrations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentModule" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="entryPoint"></param>
        /// <param name="className"></param>
        /// <param name="initInputs"></param>
        /// <param name="functions"></param>
        /// <param name="mandatory"></param>
        /// <param name="versions"></param>
        /// <param name="config"></param>
        /// <param name="serviceConfig">
        /// Make all properties in T optional
        /// </param>
        /// <param name="computeConfig"></param>
        /// <param name="integrations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkComponentModule(
            string name,
            string entryPoint,
            string className,
            global::System.Collections.Generic.IList<global::Dataloop.PackageIO> initInputs,
            global::System.Collections.Generic.IList<global::Dataloop.DLFunction> functions,
            bool? mandatory,
            global::Dataloop.JsServiceVersions? versions,
            global::Dataloop.IServiceAppConfig? config,
            global::Dataloop.PartialService? serviceConfig,
            string? computeConfig,
            global::System.Collections.Generic.IList<string>? integrations)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EntryPoint = entryPoint ?? throw new global::System.ArgumentNullException(nameof(entryPoint));
            this.ClassName = className ?? throw new global::System.ArgumentNullException(nameof(className));
            this.InitInputs = initInputs ?? throw new global::System.ArgumentNullException(nameof(initInputs));
            this.Functions = functions ?? throw new global::System.ArgumentNullException(nameof(functions));
            this.Mandatory = mandatory;
            this.Versions = versions;
            this.Config = config;
            this.ServiceConfig = serviceConfig;
            this.ComputeConfig = computeConfig;
            this.Integrations = integrations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentModule" /> class.
        /// </summary>
        public IDpkComponentModule()
        {
        }
    }
}