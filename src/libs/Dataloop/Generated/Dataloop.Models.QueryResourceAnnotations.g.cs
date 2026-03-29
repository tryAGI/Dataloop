
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryResourceAnnotations
    {
        /// <summary>
        /// 
        /// </summary>
        Annotations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryResourceAnnotationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryResourceAnnotations value)
        {
            return value switch
            {
                QueryResourceAnnotations.Annotations => "annotations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryResourceAnnotations? ToEnum(string value)
        {
            return value switch
            {
                "annotations" => QueryResourceAnnotations.Annotations,
                _ => null,
            };
        }
    }
}