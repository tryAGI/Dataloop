
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CommandStatus
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
        CleaningUp,
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
        Finalizing,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        MakingChildren,
        /// <summary>
        /// 
        /// </summary>
        OnError,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
        /// <summary>
        /// 
        /// </summary>
        WaitingChildren,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommandStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommandStatus value)
        {
            return value switch
            {
                CommandStatus.Aborted => "aborted",
                CommandStatus.Canceled => "canceled",
                CommandStatus.CleaningUp => "cleaning-up",
                CommandStatus.Created => "created",
                CommandStatus.Failed => "failed",
                CommandStatus.Finalizing => "finalizing",
                CommandStatus.InProgress => "in-progress",
                CommandStatus.MakingChildren => "making-children",
                CommandStatus.OnError => "on-error",
                CommandStatus.Success => "success",
                CommandStatus.Timeout => "timeout",
                CommandStatus.WaitingChildren => "waiting-children",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommandStatus? ToEnum(string value)
        {
            return value switch
            {
                "aborted" => CommandStatus.Aborted,
                "canceled" => CommandStatus.Canceled,
                "cleaning-up" => CommandStatus.CleaningUp,
                "created" => CommandStatus.Created,
                "failed" => CommandStatus.Failed,
                "finalizing" => CommandStatus.Finalizing,
                "in-progress" => CommandStatus.InProgress,
                "making-children" => CommandStatus.MakingChildren,
                "on-error" => CommandStatus.OnError,
                "success" => CommandStatus.Success,
                "timeout" => CommandStatus.Timeout,
                "waiting-children" => CommandStatus.WaitingChildren,
                _ => null,
            };
        }
    }
}