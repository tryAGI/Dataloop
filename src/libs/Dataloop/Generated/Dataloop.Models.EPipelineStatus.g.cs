
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EPipelineStatus
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
        Rerun,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Terminated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EPipelineStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EPipelineStatus value)
        {
            return value switch
            {
                EPipelineStatus.Failed => "failed",
                EPipelineStatus.InProgress => "in-progress",
                EPipelineStatus.Pending => "pending",
                EPipelineStatus.Queue => "queue",
                EPipelineStatus.Rerun => "rerun",
                EPipelineStatus.Success => "success",
                EPipelineStatus.Terminated => "terminated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EPipelineStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => EPipelineStatus.Failed,
                "in-progress" => EPipelineStatus.InProgress,
                "pending" => EPipelineStatus.Pending,
                "queue" => EPipelineStatus.Queue,
                "rerun" => EPipelineStatus.Rerun,
                "success" => EPipelineStatus.Success,
                "terminated" => EPipelineStatus.Terminated,
                _ => null,
            };
        }
    }
}