
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CrashloopAction
    {
        /// <summary>
        /// 
        /// </summary>
        Deactivate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CrashloopActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CrashloopAction value)
        {
            return value switch
            {
                CrashloopAction.Deactivate => "deactivate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CrashloopAction? ToEnum(string value)
        {
            return value switch
            {
                "deactivate" => CrashloopAction.Deactivate,
                _ => null,
            };
        }
    }
}