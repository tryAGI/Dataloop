
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReplicaStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Down,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Full,
        /// <summary>
        /// 
        /// </summary>
        Initializing,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Terminating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplicaStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplicaStatus value)
        {
            return value switch
            {
                ReplicaStatus.Down => "down",
                ReplicaStatus.Failed => "failed",
                ReplicaStatus.Full => "full",
                ReplicaStatus.Initializing => "initializing",
                ReplicaStatus.Paused => "paused",
                ReplicaStatus.Running => "running",
                ReplicaStatus.Terminating => "terminating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplicaStatus? ToEnum(string value)
        {
            return value switch
            {
                "down" => ReplicaStatus.Down,
                "failed" => ReplicaStatus.Failed,
                "full" => ReplicaStatus.Full,
                "initializing" => ReplicaStatus.Initializing,
                "paused" => ReplicaStatus.Paused,
                "running" => ReplicaStatus.Running,
                "terminating" => ReplicaStatus.Terminating,
                _ => null,
            };
        }
    }
}