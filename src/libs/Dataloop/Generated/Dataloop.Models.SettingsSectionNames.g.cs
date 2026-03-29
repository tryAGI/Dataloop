
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum SettingsSectionNames
    {
        /// <summary>
        /// 
        /// </summary>
        Account,
        /// <summary>
        /// 
        /// </summary>
        Applications,
        /// <summary>
        /// 
        /// </summary>
        Contact,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        Sdk,
        /// <summary>
        /// 
        /// </summary>
        Studio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SettingsSectionNamesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SettingsSectionNames value)
        {
            return value switch
            {
                SettingsSectionNames.Account => "Account",
                SettingsSectionNames.Applications => "Applications",
                SettingsSectionNames.Contact => "Contact",
                SettingsSectionNames.Platform => "Platform",
                SettingsSectionNames.Sdk => "SDK",
                SettingsSectionNames.Studio => "Studio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SettingsSectionNames? ToEnum(string value)
        {
            return value switch
            {
                "Account" => SettingsSectionNames.Account,
                "Applications" => SettingsSectionNames.Applications,
                "Contact" => SettingsSectionNames.Contact,
                "Platform" => SettingsSectionNames.Platform,
                "SDK" => SettingsSectionNames.Sdk,
                "Studio" => SettingsSectionNames.Studio,
                _ => null,
            };
        }
    }
}