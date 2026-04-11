
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EAppScope
    {
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EAppScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EAppScope value)
        {
            return value switch
            {
                EAppScope.Project => "project",
                EAppScope.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EAppScope? ToEnum(string value)
        {
            return value switch
            {
                "project" => EAppScope.Project,
                "system" => EAppScope.System,
                _ => null,
            };
        }
    }
}