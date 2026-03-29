
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialSettingScope
    {
        /// <summary>
        /// The type for which the setting belongs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>))]
        public global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>? Type { get; set; }

        /// <summary>
        /// The id for which the setting belongs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.PartialSettingScopeId?>))]
        public global::Dataloop.AnyOf<string, global::Dataloop.PartialSettingScopeId?>? Id { get; set; }

        /// <summary>
        /// The role for which the setting belongs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>))]
        public global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>? Role { get; set; }

        /// <summary>
        /// allow other settings to override this setting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preventOverride")]
        public bool? PreventOverride { get; set; }

        /// <summary>
        /// a toggle if the setting is visible or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialSettingScope" /> class.
        /// </summary>
        /// <param name="type">
        /// The type for which the setting belongs
        /// </param>
        /// <param name="id">
        /// The id for which the setting belongs
        /// </param>
        /// <param name="role">
        /// The role for which the setting belongs
        /// </param>
        /// <param name="preventOverride">
        /// allow other settings to override this setting
        /// </param>
        /// <param name="visible">
        /// a toggle if the setting is visible or not
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialSettingScope(
            global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>? type,
            global::Dataloop.AnyOf<string, global::Dataloop.PartialSettingScopeId?>? id,
            global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>? role,
            bool? preventOverride,
            bool? visible)
        {
            this.Type = type;
            this.Id = id;
            this.Role = role;
            this.PreventOverride = preventOverride;
            this.Visible = visible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialSettingScope" /> class.
        /// </summary>
        public PartialSettingScope()
        {
        }
    }
}