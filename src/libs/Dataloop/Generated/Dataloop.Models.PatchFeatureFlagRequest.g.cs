
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchFeatureFlagRequest
    {
        /// <summary>
        /// the value that will be taken if no value was passed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultValue")]
        public object? DefaultValue { get; set; }

        /// <summary>
        /// the value of the setting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// the value type of the setting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.SettingsValueTypesJsonConverter))]
        public global::Dataloop.SettingsValueTypes? ValueType { get; set; }

        /// <summary>
        /// the scope in which the setting is defined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::Dataloop.PartialSettingScope? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.Dictionary? Metadata { get; set; }

        /// <summary>
        /// the date the feature flag expired
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiredAt")]
        public global::System.DateTime? ExpiredAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchFeatureFlagRequest" /> class.
        /// </summary>
        /// <param name="defaultValue">
        /// the value that will be taken if no value was passed
        /// </param>
        /// <param name="value">
        /// the value of the setting
        /// </param>
        /// <param name="valueType">
        /// the value type of the setting
        /// </param>
        /// <param name="scope">
        /// the scope in which the setting is defined.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="expiredAt">
        /// the date the feature flag expired
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchFeatureFlagRequest(
            object? defaultValue,
            object? value,
            global::Dataloop.SettingsValueTypes? valueType,
            global::Dataloop.PartialSettingScope? scope,
            global::Dataloop.Dictionary? metadata,
            global::System.DateTime? expiredAt)
        {
            this.DefaultValue = defaultValue;
            this.Value = value;
            this.ValueType = valueType;
            this.Scope = scope;
            this.Metadata = metadata;
            this.ExpiredAt = expiredAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchFeatureFlagRequest" /> class.
        /// </summary>
        public PatchFeatureFlagRequest()
        {
        }
    }
}