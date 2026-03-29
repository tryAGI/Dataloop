
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIUserSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// the value that will be taken if no value was passed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DefaultValue { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settingType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.SettingsTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.SettingsTypes SettingType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

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
        /// description field for the user setting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// inputs specified for the user setting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Inputs { get; set; }

        /// <summary>
        /// an icon for the setting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// a hint for the setting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hint")]
        public string? Hint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sectionName")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.SettingsSectionNamesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.SettingsSectionNames SectionName { get; set; }

        /// <summary>
        /// the sub section that the setting belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subSectionName")]
        public string? SubSectionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUserSetting" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="defaultValue">
        /// the value that will be taken if no value was passed
        /// </param>
        /// <param name="name">
        /// the name of the setting
        /// </param>
        /// <param name="value">
        /// the value of the setting
        /// </param>
        /// <param name="valueType"></param>
        /// <param name="scope"></param>
        /// <param name="metadata"></param>
        /// <param name="settingType"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="updatedAt"></param>
        /// <param name="inputs">
        /// inputs specified for the user setting
        /// </param>
        /// <param name="sectionName"></param>
        /// <param name="updatedBy"></param>
        /// <param name="description">
        /// description field for the user setting
        /// </param>
        /// <param name="icon">
        /// an icon for the setting
        /// </param>
        /// <param name="hint">
        /// a hint for the setting
        /// </param>
        /// <param name="subSectionName">
        /// the sub section that the setting belongs to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIUserSetting(
            string id,
            object defaultValue,
            string name,
            object value,
            global::Dataloop.SettingsValueTypes valueType,
            global::Dataloop.SettingScope scope,
            global::Dataloop.Dictionary metadata,
            global::Dataloop.SettingsTypes settingType,
            global::System.DateTime createdAt,
            string createdBy,
            global::System.DateTime updatedAt,
            object inputs,
            global::Dataloop.SettingsSectionNames sectionName,
            string? updatedBy,
            string? description,
            string? icon,
            string? hint,
            string? subSectionName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DefaultValue = defaultValue ?? throw new global::System.ArgumentNullException(nameof(defaultValue));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.ValueType = valueType;
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.SettingType = settingType;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Description = description;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Icon = icon;
            this.Hint = hint;
            this.SectionName = sectionName;
            this.SubSectionName = subSectionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUserSetting" /> class.
        /// </summary>
        public APIUserSetting()
        {
        }
    }
}