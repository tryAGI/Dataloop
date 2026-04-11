
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        CompletedWithIssues,
        /// <summary>
        /// 
        /// </summary>
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskStatus value)
        {
            return value switch
            {
                TaskStatus.Completed => "completed",
                TaskStatus.CompletedWithIssues => "completed with issues",
                TaskStatus.Dismissed => "dismissed",
                TaskStatus.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TaskStatus.Completed,
                "completed with issues" => TaskStatus.CompletedWithIssues,
                "dismissed" => TaskStatus.Dismissed,
                "open" => TaskStatus.Open,
                _ => null,
            };
        }
    }
}