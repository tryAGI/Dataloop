
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationTypeBox
    {
        /// <summary>
        /// 
        /// </summary>
        Box,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationTypeBoxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationTypeBox value)
        {
            return value switch
            {
                AnnotationTypeBox.Box => "box",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationTypeBox? ToEnum(string value)
        {
            return value switch
            {
                "box" => AnnotationTypeBox.Box,
                _ => null,
            };
        }
    }
}