
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIFeatureFlag
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
        /// the date the feature flag expired
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiredAt")]
        public global::System.DateTime? ExpiredAt { get; set; }

        /// <summary>
        /// value of that is interpreted from the expired at date. it signals if the flag is expired or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Expired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIFeatureFlag" /> class.
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
        /// <param name="expired">
        /// value of that is interpreted from the expired at date. it signals if the flag is expired or not
        /// </param>
        /// <param name="updatedBy"></param>
        /// <param name="expiredAt">
        /// the date the feature flag expired
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIFeatureFlag(
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
            bool expired,
            string? updatedBy,
            global::System.DateTime? expiredAt)
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
            this.ExpiredAt = expiredAt;
            this.Expired = expired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIFeatureFlag" /> class.
        /// </summary>
        public APIFeatureFlag()
        {
        }
    }
}