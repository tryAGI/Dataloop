
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIPatchApp
    {
        /// <summary>
        /// The app name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("trusted")]
        public bool? Trusted { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPatchApp" /> class.
        /// </summary>
        /// <param name="name">
        /// The app name
        /// </param>
        /// <param name="dpkName">
        /// A unique DPK app name
        /// </param>
        /// <param name="dpkVersion">
        /// The version of the dpk app
        /// </param>
        /// <param name="trusted"></param>
        /// <param name="customInstallation"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIPatchApp(
            string name,
            string dpkName,
            string? dpkVersion,
            bool? trusted,
            global::Dataloop.CustomInstallation? customInstallation,
            global::Dataloop.CompositionStatus? status)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DpkName = dpkName ?? throw new global::System.ArgumentNullException(nameof(dpkName));
            this.DpkVersion = dpkVersion;
            this.Trusted = trusted;
            this.CustomInstallation = customInstallation;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIPatchApp" /> class.
        /// </summary>
        public APIPatchApp()
        {
        }
    }
}