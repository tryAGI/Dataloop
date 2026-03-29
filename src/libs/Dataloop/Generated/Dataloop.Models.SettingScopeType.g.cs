
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum SettingScopeType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataloop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SettingScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SettingScopeType value)
        {
            return value switch
            {
                SettingScopeType.Dataloop => "DATALOOP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SettingScopeType? ToEnum(string value)
        {
            return value switch
            {
                "DATALOOP" => SettingScopeType.Dataloop,
                _ => null,
            };
        }
    }
}