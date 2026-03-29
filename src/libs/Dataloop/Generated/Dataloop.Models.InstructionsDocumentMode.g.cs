
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum InstructionsDocumentMode
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Range,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InstructionsDocumentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstructionsDocumentMode value)
        {
            return value switch
            {
                InstructionsDocumentMode.All => "all",
                InstructionsDocumentMode.None => "none",
                InstructionsDocumentMode.Range => "range",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstructionsDocumentMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => InstructionsDocumentMode.All,
                "none" => InstructionsDocumentMode.None,
                "range" => InstructionsDocumentMode.Range,
                _ => null,
            };
        }
    }
}