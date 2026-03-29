
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum SettingsTypes
    {
        /// <summary>
        /// 
        /// </summary>
        FeatureFlag,
        /// <summary>
        /// 
        /// </summary>
        UserSettings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SettingsTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SettingsTypes value)
        {
            return value switch
            {
                SettingsTypes.FeatureFlag => "feature_flag",
                SettingsTypes.UserSettings => "user_settings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SettingsTypes? ToEnum(string value)
        {
            return value switch
            {
                "feature_flag" => SettingsTypes.FeatureFlag,
                "user_settings" => SettingsTypes.UserSettings,
                _ => null,
            };
        }
    }
}