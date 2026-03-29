
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddItemMode
    {
        /// <summary>
        /// 
        /// </summary>
        Overwrite,
        /// <summary>
        /// 
        /// </summary>
        Skip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddItemModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddItemMode value)
        {
            return value switch
            {
                AddItemMode.Overwrite => "overwrite",
                AddItemMode.Skip => "skip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddItemMode? ToEnum(string value)
        {
            return value switch
            {
                "overwrite" => AddItemMode.Overwrite,
                "skip" => AddItemMode.Skip,
                _ => null,
            };
        }
    }
}