
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrgRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Worker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgRole value)
        {
            return value switch
            {
                OrgRole.Admin => "admin",
                OrgRole.Member => "member",
                OrgRole.Owner => "owner",
                OrgRole.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => OrgRole.Admin,
                "member" => OrgRole.Member,
                "owner" => OrgRole.Owner,
                "worker" => OrgRole.Worker,
                _ => null,
            };
        }
    }
}