
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EDpkScope
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EDpkScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EDpkScope value)
        {
            return value switch
            {
                EDpkScope.Organization => "organization",
                EDpkScope.Project => "project",
                EDpkScope.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EDpkScope? ToEnum(string value)
        {
            return value switch
            {
                "organization" => EDpkScope.Organization,
                "project" => EDpkScope.Project,
                "public" => EDpkScope.Public,
                _ => null,
            };
        }
    }
}