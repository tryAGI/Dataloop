
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum APICustomActionControls
    {
        /// <summary>
        /// 
        /// </summary>
        Button,
        /// <summary>
        /// 
        /// </summary>
        Checkbox,
        /// <summary>
        /// 
        /// </summary>
        Radio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class APICustomActionControlsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APICustomActionControls value)
        {
            return value switch
            {
                APICustomActionControls.Button => "button",
                APICustomActionControls.Checkbox => "checkbox",
                APICustomActionControls.Radio => "radio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APICustomActionControls? ToEnum(string value)
        {
            return value switch
            {
                "button" => APICustomActionControls.Button,
                "checkbox" => APICustomActionControls.Checkbox,
                "radio" => APICustomActionControls.Radio,
                _ => null,
            };
        }
    }
}