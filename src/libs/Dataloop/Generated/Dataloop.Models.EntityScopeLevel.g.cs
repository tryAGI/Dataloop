
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EntityScopeLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        Private,
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
    public static class EntityScopeLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityScopeLevel value)
        {
            return value switch
            {
                EntityScopeLevel.Org => "org",
                EntityScopeLevel.Private => "private",
                EntityScopeLevel.Project => "project",
                EntityScopeLevel.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityScopeLevel? ToEnum(string value)
        {
            return value switch
            {
                "org" => EntityScopeLevel.Org,
                "private" => EntityScopeLevel.Private,
                "project" => EntityScopeLevel.Project,
                "public" => EntityScopeLevel.Public,
                _ => null,
            };
        }
    }
}