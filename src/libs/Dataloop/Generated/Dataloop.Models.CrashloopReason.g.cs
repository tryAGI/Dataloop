
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CrashloopReason
    {
        /// <summary>
        /// 
        /// </summary>
        Depletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CrashloopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CrashloopReason value)
        {
            return value switch
            {
                CrashloopReason.Depletion => "depletion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CrashloopReason? ToEnum(string value)
        {
            return value switch
            {
                "depletion" => CrashloopReason.Depletion,
                _ => null,
            };
        }
    }
}