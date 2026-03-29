
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetItemType
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
    public static class DatasetItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetItemType value)
        {
            return value switch
            {
                DatasetItemType.Dir => "dir",
                DatasetItemType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetItemType? ToEnum(string value)
        {
            return value switch
            {
                "dir" => DatasetItemType.Dir,
                "file" => DatasetItemType.File,
                _ => null,
            };
        }
    }
}