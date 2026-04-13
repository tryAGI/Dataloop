
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIApp
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpkName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DpkName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpkVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DpkVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compositionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompositionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EAppScopeJsonConverter))]
        public global::Dataloop.EAppScope? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Routes { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpk")]
        public global::Dataloop.PartialAPIDpk? Dpk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customInstallation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CustomInstallationJsonConverter))]
        public global::Dataloop.CustomInstallation? CustomInstallation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CompositionStatusJsonConverter))]
        public global::Dataloop.CompositionStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trusted")]
        public bool? Trusted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AppMetadataJsonConverter))]
        public global::Dataloop.AppMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Dataloop.IAppGeneralSettings? Settings { get; set; }

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
        /// Initializes a new instance of the <see cref="APIApp" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="projectId"></param>
        /// <param name="orgId"></param>
        /// <param name="dpkName"></param>
        /// <param name="dpkVersion"></param>
        /// <param name="compositionId"></param>
        /// <param name="routes"></param>
        /// <param name="updatedBy"></param>
        /// <param name="scope"></param>
        /// <param name="dpk">
        /// Make all properties in T optional
        /// </param>
        /// <param name="customInstallation"></param>
        /// <param name="status"></param>
        /// <param name="trusted"></param>
        /// <param name="metadata"></param>
        /// <param name="settings"></param>
        /// <param name="integrations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIApp(
            string id,
            string url,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string creator,
            string projectId,
            string orgId,
            string dpkName,
            string dpkVersion,
            string compositionId,
            global::Dataloop.Dictionary routes,
            string? updatedBy,
            global::Dataloop.EAppScope? scope,
            global::Dataloop.PartialAPIDpk? dpk,
            global::Dataloop.CustomInstallation? customInstallation,
            global::Dataloop.CompositionStatus? status,
            bool? trusted,
            global::Dataloop.AppMetadata? metadata,
            global::Dataloop.IAppGeneralSettings? settings,
            global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? integrations)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.DpkName = dpkName ?? throw new global::System.ArgumentNullException(nameof(dpkName));
            this.DpkVersion = dpkVersion ?? throw new global::System.ArgumentNullException(nameof(dpkVersion));
            this.CompositionId = compositionId ?? throw new global::System.ArgumentNullException(nameof(compositionId));
            this.Scope = scope;
            this.Routes = routes ?? throw new global::System.ArgumentNullException(nameof(routes));
            this.Dpk = dpk;
            this.CustomInstallation = customInstallation;
            this.Status = status;
            this.Trusted = trusted;
            this.Metadata = metadata;
            this.Settings = settings;
            this.Integrations = integrations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIApp" /> class.
        /// </summary>
        public APIApp()
        {
        }
    }
}