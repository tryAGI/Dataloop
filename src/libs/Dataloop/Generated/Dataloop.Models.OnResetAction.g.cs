
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum OnResetAction
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Rerun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OnResetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OnResetAction value)
        {
            return value switch
            {
                OnResetAction.Failed => "failed",
                OnResetAction.Rerun => "rerun",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OnResetAction? ToEnum(string value)
        {
            return value switch
            {
                "failed" => OnResetAction.Failed,
                "rerun" => OnResetAction.Rerun,
                _ => null,
            };
        }
    }
}