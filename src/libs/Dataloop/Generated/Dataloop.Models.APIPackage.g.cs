
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIPackage
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
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Global { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codebase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Codebase Codebase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.Module> Modules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uiHooks")]
        public global::System.Collections.Generic.IList<global::Dataloop.UiHook>? UiHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slots")]
        public global::System.Collections.Generic.IList<global::Dataloop.PiperUiSlot>? Slots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceConfig")]
        public global::Dataloop.ServiceConfig? ServiceConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.PackageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.PackageType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>? Requirements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.PackageMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panels")]
        public global::System.Collections.Generic.IList<global::Dataloop.Panel>? Panels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPackage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="version"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="updatedBy"></param>
        /// <param name="name"></param>
        /// <param name="global"></param>
        /// <param name="projectId"></param>
        /// <param name="codebase"></param>
        /// <param name="modules"></param>
        /// <param name="type"></param>
        /// <param name="uiHooks"></param>
        /// <param name="slots"></param>
        /// <param name="serviceConfig"></param>
        /// <param name="requirements"></param>
        /// <param name="metadata"></param>
        /// <param name="panels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIPackage(
            string id,
            string url,
            string version,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string creator,
            string updatedBy,
            string name,
            bool global,
            string projectId,
            global::Dataloop.Codebase codebase,
            global::System.Collections.Generic.IList<global::Dataloop.Module> modules,
            global::Dataloop.PackageType type,
            global::System.Collections.Generic.IList<global::Dataloop.UiHook>? uiHooks,
            global::System.Collections.Generic.IList<global::Dataloop.PiperUiSlot>? slots,
            global::Dataloop.ServiceConfig? serviceConfig,
            global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>? requirements,
            global::Dataloop.PackageMetadata? metadata,
            global::System.Collections.Generic.IList<global::Dataloop.Panel>? panels)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.UpdatedBy = updatedBy ?? throw new global::System.ArgumentNullException(nameof(updatedBy));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Global = global;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Codebase = codebase ?? throw new global::System.ArgumentNullException(nameof(codebase));
            this.Modules = modules ?? throw new global::System.ArgumentNullException(nameof(modules));
            this.UiHooks = uiHooks;
            this.Slots = slots;
            this.ServiceConfig = serviceConfig;
            this.Type = type;
            this.Requirements = requirements;
            this.Metadata = metadata;
            this.Panels = panels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPackage" /> class.
        /// </summary>
        public APIPackage()
        {
        }
    }
}