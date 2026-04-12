
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionHookType
    {
        /// <summary>
        /// 
        /// </summary>
        Command,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionHookTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionHookType value)
        {
            return value switch
            {
                ExecutionHookType.Command => "command",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionHookType? ToEnum(string value)
        {
            return value switch
            {
                "command" => ExecutionHookType.Command,
                _ => null,
            };
        }
    }
}