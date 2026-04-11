
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionPhase
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionPhaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionPhase value)
        {
            return value switch
            {
                ExecutionPhase.Completed => "completed",
                ExecutionPhase.Pending => "pending",
                ExecutionPhase.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionPhase? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ExecutionPhase.Completed,
                "pending" => ExecutionPhase.Pending,
                "running" => ExecutionPhase.Running,
                _ => null,
            };
        }
    }
}