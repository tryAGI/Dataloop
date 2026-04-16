
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EDebugOptionsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Activate,
        /// <summary>
        /// 
        /// </summary>
        Deactivate,
        /// <summary>
        /// 
        /// </summary>
        Placed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EDebugOptionsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EDebugOptionsStatus value)
        {
            return value switch
            {
                EDebugOptionsStatus.Activate => "activate",
                EDebugOptionsStatus.Deactivate => "deactivate",
                EDebugOptionsStatus.Placed => "placed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EDebugOptionsStatus? ToEnum(string value)
        {
            return value switch
            {
                "activate" => EDebugOptionsStatus.Activate,
                "deactivate" => EDebugOptionsStatus.Deactivate,
                "placed" => EDebugOptionsStatus.Placed,
                _ => null,
            };
        }
    }
}