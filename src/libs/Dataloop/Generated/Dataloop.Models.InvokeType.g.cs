
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum InvokeType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Panel,
        /// <summary>
        /// 
        /// </summary>
        Script,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvokeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvokeType value)
        {
            return value switch
            {
                InvokeType.Function => "function",
                InvokeType.Panel => "panel",
                InvokeType.Script => "script",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvokeType? ToEnum(string value)
        {
            return value switch
            {
                "function" => InvokeType.Function,
                "panel" => InvokeType.Panel,
                "script" => InvokeType.Script,
                _ => null,
            };
        }
    }
}