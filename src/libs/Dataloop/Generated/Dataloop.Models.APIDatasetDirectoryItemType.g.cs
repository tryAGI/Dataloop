
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum APIDatasetDirectoryItemType
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
    public static class APIDatasetDirectoryItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APIDatasetDirectoryItemType value)
        {
            return value switch
            {
                APIDatasetDirectoryItemType.Dir => "dir",
                APIDatasetDirectoryItemType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APIDatasetDirectoryItemType? ToEnum(string value)
        {
            return value switch
            {
                "dir" => APIDatasetDirectoryItemType.Dir,
                "file" => APIDatasetDirectoryItemType.File,
                _ => null,
            };
        }
    }
}