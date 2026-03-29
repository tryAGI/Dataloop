
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomActionControls
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
    public static class CustomActionControlsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomActionControls value)
        {
            return value switch
            {
                CustomActionControls.Button => "button",
                CustomActionControls.Checkbox => "checkbox",
                CustomActionControls.Radio => "radio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomActionControls? ToEnum(string value)
        {
            return value switch
            {
                "button" => CustomActionControls.Button,
                "checkbox" => CustomActionControls.Checkbox,
                "radio" => CustomActionControls.Radio,
                _ => null,
            };
        }
    }
}