
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Always,
        /// <summary>
        /// 
        /// </summary>
        Once,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionMode value)
        {
            return value switch
            {
                ExecutionMode.Always => "Always",
                ExecutionMode.Once => "Once",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "Always" => ExecutionMode.Always,
                "Once" => ExecutionMode.Once,
                _ => null,
            };
        }
    }
}