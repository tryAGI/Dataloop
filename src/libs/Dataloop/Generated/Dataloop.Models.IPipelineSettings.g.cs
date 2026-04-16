
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IPipelineSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultResumeOption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ResumePipelineOptionJsonConverter))]
        public global::Dataloop.ResumePipelineOption? DefaultResumeOption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepTriggersActive")]
        public bool? KeepTriggersActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeTriggerAskAgain")]
        public bool? ActiveTriggerAskAgain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IPipelineSettingsLastUpdate LastUpdate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IPipelineSettings" /> class.
        /// </summary>
        /// <param name="lastUpdate"></param>
        /// <param name="defaultResumeOption"></param>
        /// <param name="keepTriggersActive"></param>
        /// <param name="activeTriggerAskAgain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IPipelineSettings(
            global::Dataloop.IPipelineSettingsLastUpdate lastUpdate,
            global::Dataloop.ResumePipelineOption? defaultResumeOption,
            bool? keepTriggersActive,
            bool? activeTriggerAskAgain)
        {
            this.DefaultResumeOption = defaultResumeOption;
            this.KeepTriggersActive = keepTriggersActive;
            this.ActiveTriggerAskAgain = activeTriggerAskAgain;
            this.LastUpdate = lastUpdate ?? throw new global::System.ArgumentNullException(nameof(lastUpdate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPipelineSettings" /> class.
        /// </summary>
        public IPipelineSettings()
        {
        }
    }
}