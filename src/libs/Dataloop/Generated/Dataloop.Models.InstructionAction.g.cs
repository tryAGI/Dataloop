
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum InstructionAction
    {
        /// <summary>
        /// 
        /// </summary>
        Annotate,
        /// <summary>
        /// 
        /// </summary>
        Change,
        /// <summary>
        /// 
        /// </summary>
        Remove,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InstructionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstructionAction value)
        {
            return value switch
            {
                InstructionAction.Annotate => "annotate",
                InstructionAction.Change => "change",
                InstructionAction.Remove => "remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstructionAction? ToEnum(string value)
        {
            return value switch
            {
                "annotate" => InstructionAction.Annotate,
                "change" => InstructionAction.Change,
                "remove" => InstructionAction.Remove,
                _ => null,
            };
        }
    }
}