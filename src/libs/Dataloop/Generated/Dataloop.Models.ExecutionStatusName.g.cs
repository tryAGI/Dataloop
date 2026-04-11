
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionStatusName
    {
        /// <summary>
        /// 
        /// </summary>
        Aborted,
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
        /// <summary>
        /// 
        /// </summary>
        SystemFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionStatusNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionStatusName value)
        {
            return value switch
            {
                ExecutionStatusName.Aborted => "aborted",
                ExecutionStatusName.Canceled => "canceled",
                ExecutionStatusName.Created => "created",
                ExecutionStatusName.Failed => "failed",
                ExecutionStatusName.InProgress => "in-progress",
                ExecutionStatusName.Rerun => "rerun",
                ExecutionStatusName.Success => "success",
                ExecutionStatusName.SystemFailure => "system-failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionStatusName? ToEnum(string value)
        {
            return value switch
            {
                "aborted" => ExecutionStatusName.Aborted,
                "canceled" => ExecutionStatusName.Canceled,
                "created" => ExecutionStatusName.Created,
                "failed" => ExecutionStatusName.Failed,
                "in-progress" => ExecutionStatusName.InProgress,
                "rerun" => ExecutionStatusName.Rerun,
                "success" => ExecutionStatusName.Success,
                "system-failure" => ExecutionStatusName.SystemFailure,
                _ => null,
            };
        }
    }
}