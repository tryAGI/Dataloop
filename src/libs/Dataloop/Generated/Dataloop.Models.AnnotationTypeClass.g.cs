
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationTypeClass
    {
        /// <summary>
        /// 
        /// </summary>
        Class,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationTypeClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationTypeClass value)
        {
            return value switch
            {
                AnnotationTypeClass.Class => "class",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationTypeClass? ToEnum(string value)
        {
            return value switch
            {
                "class" => AnnotationTypeClass.Class,
                _ => null,
            };
        }
    }
}