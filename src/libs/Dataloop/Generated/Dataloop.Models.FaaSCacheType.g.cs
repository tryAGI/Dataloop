
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum FaaSCacheType
    {
        /// <summary>
        /// 
        /// </summary>
        Ssd,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaaSCacheTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaaSCacheType value)
        {
            return value switch
            {
                FaaSCacheType.Ssd => "ssd",
                FaaSCacheType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaaSCacheType? ToEnum(string value)
        {
            return value switch
            {
                "ssd" => FaaSCacheType.Ssd,
                "standard" => FaaSCacheType.Standard,
                _ => null,
            };
        }
    }
}