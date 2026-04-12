
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkComponentPanel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minRole")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MinRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedSlots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentPanelSupportedSlot> SupportedSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::Dataloop.Dictionary? Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultSettings")]
        public global::Dataloop.Dictionary? DefaultSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serveFromFilesystem")]
        public bool? ServeFromFilesystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computeConfig")]
        public string? ComputeConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentPanel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minRole"></param>
        /// <param name="supportedSlots"></param>
        /// <param name="icon"></param>
        /// <param name="metadata"></param>
        /// <param name="mandatory"></param>
        /// <param name="path"></param>
        /// <param name="conditions"></param>
        /// <param name="defaultSettings"></param>
        /// <param name="serveFromFilesystem"></param>
        /// <param name="computeConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkComponentPanel(
            string name,
            string minRole,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentPanelSupportedSlot> supportedSlots,
            string icon,
            global::Dataloop.Dictionary metadata,
            bool? mandatory,
            string? path,
            global::Dataloop.Dictionary? conditions,
            global::Dataloop.Dictionary? defaultSettings,
            bool? serveFromFilesystem,
            string? computeConfig)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Mandatory = mandatory;
            this.Path = path;
            this.MinRole = minRole ?? throw new global::System.ArgumentNullException(nameof(minRole));
            this.SupportedSlots = supportedSlots ?? throw new global::System.ArgumentNullException(nameof(supportedSlots));
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Conditions = conditions;
            this.DefaultSettings = defaultSettings;
            this.ServeFromFilesystem = serveFromFilesystem;
            this.ComputeConfig = computeConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentPanel" /> class.
        /// </summary>
        public IDpkComponentPanel()
        {
        }
    }
}