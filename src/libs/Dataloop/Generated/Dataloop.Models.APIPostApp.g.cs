
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIPostApp
    {
        /// <summary>
        /// The app name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The project where the app should be install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// A unique DPK app name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpkName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DpkName { get; set; }

        /// <summary>
        /// The version of the dpk app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpkVersion")]
        public string? DpkVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.EAppScopeJsonConverter))]
        public global::Dataloop.EAppScope? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customInstallation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CustomInstallationJsonConverter))]
        public global::Dataloop.CustomInstallation? CustomInstallation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPostApp" /> class.
        /// </summary>
        /// <param name="name">
        /// The app name
        /// </param>
        /// <param name="projectId">
        /// The project where the app should be install
        /// </param>
        /// <param name="dpkName">
        /// A unique DPK app name
        /// </param>
        /// <param name="dpkVersion">
        /// The version of the dpk app
        /// </param>
        /// <param name="scope"></param>
        /// <param name="customInstallation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIPostApp(
            string name,
            string projectId,
            string dpkName,
            string? dpkVersion,
            global::Dataloop.EAppScope? scope,
            global::Dataloop.CustomInstallation? customInstallation)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DpkName = dpkName ?? throw new global::System.ArgumentNullException(nameof(dpkName));
            this.DpkVersion = dpkVersion;
            this.Scope = scope;
            this.CustomInstallation = customInstallation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPostApp" /> class.
        /// </summary>
        public APIPostApp()
        {
        }
    }
}