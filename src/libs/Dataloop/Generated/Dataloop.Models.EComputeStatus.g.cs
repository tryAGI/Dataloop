
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EComputeStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Initializing,
        /// <summary>
        /// 
        /// </summary>
        Pause,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EComputeStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EComputeStatus value)
        {
            return value switch
            {
                EComputeStatus.Failed => "failed",
                EComputeStatus.Initializing => "initializing",
                EComputeStatus.Pause => "pause",
                EComputeStatus.Ready => "ready",
                EComputeStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EComputeStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => EComputeStatus.Failed,
                "initializing" => EComputeStatus.Initializing,
                "pause" => EComputeStatus.Pause,
                "ready" => EComputeStatus.Ready,
                "validating" => EComputeStatus.Validating,
                _ => null,
            };
        }
    }
}