
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServiceModeType
    {
        /// <summary>
        /// 
        /// </summary>
        Debug,
        /// <summary>
        /// 
        /// </summary>
        Regular,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceModeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceModeType value)
        {
            return value switch
            {
                ServiceModeType.Debug => "debug",
                ServiceModeType.Regular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceModeType? ToEnum(string value)
        {
            return value switch
            {
                "debug" => ServiceModeType.Debug,
                "regular" => ServiceModeType.Regular,
                _ => null,
            };
        }
    }
}