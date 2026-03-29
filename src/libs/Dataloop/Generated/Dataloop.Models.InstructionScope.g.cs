
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum InstructionScope
    {
        /// <summary>
        /// 
        /// </summary>
        Detail,
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InstructionScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstructionScope value)
        {
            return value switch
            {
                InstructionScope.Detail => "detail",
                InstructionScope.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstructionScope? ToEnum(string value)
        {
            return value switch
            {
                "detail" => InstructionScope.Detail,
                "image" => InstructionScope.Image,
                _ => null,
            };
        }
    }
}