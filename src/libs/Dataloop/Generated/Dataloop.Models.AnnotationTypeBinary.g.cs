
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationTypeBinary
    {
        /// <summary>
        /// 
        /// </summary>
        Binary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationTypeBinaryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationTypeBinary value)
        {
            return value switch
            {
                AnnotationTypeBinary.Binary => "binary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationTypeBinary? ToEnum(string value)
        {
            return value switch
            {
                "binary" => AnnotationTypeBinary.Binary,
                _ => null,
            };
        }
    }
}