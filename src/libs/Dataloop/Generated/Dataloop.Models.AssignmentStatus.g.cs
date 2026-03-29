
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssignmentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        CompletedWithIssues,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Todo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssignmentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignmentStatus value)
        {
            return value switch
            {
                AssignmentStatus.CompletedWithIssues => "completed with issues",
                AssignmentStatus.Done => "done",
                AssignmentStatus.InProgress => "in progress",
                AssignmentStatus.Todo => "todo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignmentStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed with issues" => AssignmentStatus.CompletedWithIssues,
                "done" => AssignmentStatus.Done,
                "in progress" => AssignmentStatus.InProgress,
                "todo" => AssignmentStatus.Todo,
                _ => null,
            };
        }
    }
}