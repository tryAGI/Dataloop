
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum StartNodeType
    {
        /// <summary>
        /// 
        /// </summary>
        Root,
        /// <summary>
        /// 
        /// </summary>
        Trigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartNodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartNodeType value)
        {
            return value switch
            {
                StartNodeType.Root => "root",
                StartNodeType.Trigger => "trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartNodeType? ToEnum(string value)
        {
            return value switch
            {
                "root" => StartNodeType.Root,
                "trigger" => StartNodeType.Trigger,
                _ => null,
            };
        }
    }
}