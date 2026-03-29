
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskContributorsAction
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Remove,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskContributorsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskContributorsAction value)
        {
            return value switch
            {
                TaskContributorsAction.Add => "add",
                TaskContributorsAction.Remove => "remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskContributorsAction? ToEnum(string value)
        {
            return value switch
            {
                "add" => TaskContributorsAction.Add,
                "remove" => TaskContributorsAction.Remove,
                _ => null,
            };
        }
    }
}