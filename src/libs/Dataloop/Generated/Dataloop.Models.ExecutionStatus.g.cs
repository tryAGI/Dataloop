
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Created,
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
        Rerun,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionStatus value)
        {
            return value switch
            {
                ExecutionStatus.Canceled => "canceled",
                ExecutionStatus.Created => "created",
                ExecutionStatus.Failed => "failed",
                ExecutionStatus.InProgress => "in-progress",
                ExecutionStatus.Rerun => "rerun",
                ExecutionStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ExecutionStatus.Canceled,
                "created" => ExecutionStatus.Created,
                "failed" => ExecutionStatus.Failed,
                "in-progress" => ExecutionStatus.InProgress,
                "rerun" => ExecutionStatus.Rerun,
                "success" => ExecutionStatus.Success,
                _ => null,
            };
        }
    }
}