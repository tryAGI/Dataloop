
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum APIDatasetFileItemAnnotated
    {
        /// <summary>
        /// 
        /// </summary>
        Discarded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class APIDatasetFileItemAnnotatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APIDatasetFileItemAnnotated value)
        {
            return value switch
            {
                APIDatasetFileItemAnnotated.Discarded => "discarded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APIDatasetFileItemAnnotated? ToEnum(string value)
        {
            return value switch
            {
                "discarded" => APIDatasetFileItemAnnotated.Discarded,
                _ => null,
            };
        }
    }
}