
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFeatureFlagRequest
    {
        /// <summary>
        /// the value that will be taken if no value was passed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultValue")]
        public object? DefaultValue { get; set; }

        /// <summary>
        /// the name of the setting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// the value of the setting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.SettingsValueTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.SettingsValueTypes ValueType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.SettingScope Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.Dictionary? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settingType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.SettingsTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.SettingsTypes SettingType { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateFeatureFlagRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// the name of the setting
        /// </param>
        /// <param name="valueType"></param>
        /// <param name="scope"></param>
        /// <param name="settingType"></param>
        /// <param name="defaultValue">
        /// the value that will be taken if no value was passed
        /// </param>
        /// <param name="value">
        /// the value of the setting
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="expiredAt">
        /// the date the feature flag expired
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFeatureFlagRequest(
            string name,
            global::Dataloop.SettingsValueTypes valueType,
            global::Dataloop.SettingScope scope,
            global::Dataloop.SettingsTypes settingType,
            object? defaultValue,
            object? value,
            global::Dataloop.Dictionary? metadata,
            global::System.DateTime? expiredAt)
        {
            this.DefaultValue = defaultValue;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
            this.ValueType = valueType;
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.Metadata = metadata;
            this.SettingType = settingType;
            this.ExpiredAt = expiredAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeatureFlagRequest" /> class.
        /// </summary>
        public CreateFeatureFlagRequest()
        {
        }
    }
}