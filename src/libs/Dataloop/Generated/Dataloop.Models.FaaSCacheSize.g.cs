
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum FaaSCacheSize
    {
        /// <summary>
        /// 
        /// </summary>
        Large,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaaSCacheSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaaSCacheSize value)
        {
            return value switch
            {
                FaaSCacheSize.Large => "large",
                FaaSCacheSize.Medium => "medium",
                FaaSCacheSize.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaaSCacheSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => FaaSCacheSize.Large,
                "medium" => FaaSCacheSize.Medium,
                "small" => FaaSCacheSize.Small,
                _ => null,
            };
        }
    }
}