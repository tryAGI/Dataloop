
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum APIDatasetFileItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Dir,
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class APIDatasetFileItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APIDatasetFileItemType value)
        {
            return value switch
            {
                APIDatasetFileItemType.Dir => "dir",
                APIDatasetFileItemType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APIDatasetFileItemType? ToEnum(string value)
        {
            return value switch
            {
                "dir" => APIDatasetFileItemType.Dir,
                "file" => APIDatasetFileItemType.File,
                _ => null,
            };
        }
    }
}