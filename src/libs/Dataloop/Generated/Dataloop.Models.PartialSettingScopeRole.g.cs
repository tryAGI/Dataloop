
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PartialSettingScopeRole
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartialSettingScopeRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialSettingScopeRole value)
        {
            return value switch
            {
                PartialSettingScopeRole.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialSettingScopeRole? ToEnum(string value)
        {
            return value switch
            {
                "*" => PartialSettingScopeRole.Multiply,
                _ => null,
            };
        }
    }
}