
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum APIMembershipRole
    {
        /// <summary>
        /// 
        /// </summary>
        Superuser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class APIMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APIMembershipRole value)
        {
            return value switch
            {
                APIMembershipRole.Superuser => "superuser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APIMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "superuser" => APIMembershipRole.Superuser,
                _ => null,
            };
        }
    }
}