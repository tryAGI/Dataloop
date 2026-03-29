
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PartialSettingScopeType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataloop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartialSettingScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialSettingScopeType value)
        {
            return value switch
            {
                PartialSettingScopeType.Dataloop => "DATALOOP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialSettingScopeType? ToEnum(string value)
        {
            return value switch
            {
                "DATALOOP" => PartialSettingScopeType.Dataloop,
                _ => null,
            };
        }
    }
}