
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionHookValueFrom
    {
        /// <summary>
        /// 
        /// </summary>
        Command,
        /// <summary>
        /// 
        /// </summary>
        Execution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionHookValueFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionHookValueFrom value)
        {
            return value switch
            {
                ExecutionHookValueFrom.Command => "command",
                ExecutionHookValueFrom.Execution => "execution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionHookValueFrom? ToEnum(string value)
        {
            return value switch
            {
                "command" => ExecutionHookValueFrom.Command,
                "execution" => ExecutionHookValueFrom.Execution,
                _ => null,
            };
        }
    }
}