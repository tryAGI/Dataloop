
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum APIAnnotationEventDeleted
    {
        /// <summary>
        /// 
        /// </summary>
        Discarded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class APIAnnotationEventDeletedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APIAnnotationEventDeleted value)
        {
            return value switch
            {
                APIAnnotationEventDeleted.Discarded => "discarded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APIAnnotationEventDeleted? ToEnum(string value)
        {
            return value switch
            {
                "discarded" => APIAnnotationEventDeleted.Discarded,
                _ => null,
            };
        }
    }
}