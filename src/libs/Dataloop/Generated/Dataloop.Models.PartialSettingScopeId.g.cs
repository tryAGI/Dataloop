
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PartialSettingScopeId
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartialSettingScopeIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialSettingScopeId value)
        {
            return value switch
            {
                PartialSettingScopeId.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialSettingScopeId? ToEnum(string value)
        {
            return value switch
            {
                "*" => PartialSettingScopeId.Multiply,
                _ => null,
            };
        }
    }
}