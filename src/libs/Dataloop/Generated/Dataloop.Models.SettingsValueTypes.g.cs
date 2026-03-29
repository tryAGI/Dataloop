
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum SettingsValueTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Array,
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        MultiSelect,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        Select,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SettingsValueTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SettingsValueTypes value)
        {
            return value switch
            {
                SettingsValueTypes.Array => "array",
                SettingsValueTypes.Boolean => "boolean",
                SettingsValueTypes.MultiSelect => "multi-select",
                SettingsValueTypes.Number => "number",
                SettingsValueTypes.Object => "object",
                SettingsValueTypes.Select => "select",
                SettingsValueTypes.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SettingsValueTypes? ToEnum(string value)
        {
            return value switch
            {
                "array" => SettingsValueTypes.Array,
                "boolean" => SettingsValueTypes.Boolean,
                "multi-select" => SettingsValueTypes.MultiSelect,
                "number" => SettingsValueTypes.Number,
                "object" => SettingsValueTypes.Object,
                "select" => SettingsValueTypes.Select,
                "string" => SettingsValueTypes.String,
                _ => null,
            };
        }
    }
}