
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveSettingTraceMigrationSpecVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settingName")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>> SettingName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveSettingTraceMigrationSpecVariant2" /> class.
        /// </summary>
        /// <param name="settingName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveSettingTraceMigrationSpecVariant2(
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>> settingName)
        {
            this.SettingName = settingName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveSettingTraceMigrationSpecVariant2" /> class.
        /// </summary>
        public RemoveSettingTraceMigrationSpecVariant2()
        {
        }
    }
}