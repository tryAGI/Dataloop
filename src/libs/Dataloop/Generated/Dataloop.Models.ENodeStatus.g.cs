
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ENodeStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queue,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ENodeStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ENodeStatus value)
        {
            return value switch
            {
                ENodeStatus.Failed => "failed",
                ENodeStatus.InProgress => "in-progress",
                ENodeStatus.Pending => "pending",
                ENodeStatus.Queue => "queue",
                ENodeStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ENodeStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ENodeStatus.Failed,
                "in-progress" => ENodeStatus.InProgress,
                "pending" => ENodeStatus.Pending,
                "queue" => ENodeStatus.Queue,
                "success" => ENodeStatus.Success,
                _ => null,
            };
        }
    }
}