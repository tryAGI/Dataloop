
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodebaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Filesystem,
        /// <summary>
        /// 
        /// </summary>
        Git,
        /// <summary>
        /// 
        /// </summary>
        Item,
        /// <summary>
        /// 
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodebaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodebaseType value)
        {
            return value switch
            {
                CodebaseType.Filesystem => "filesystem",
                CodebaseType.Git => "git",
                CodebaseType.Item => "item",
                CodebaseType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodebaseType? ToEnum(string value)
        {
            return value switch
            {
                "filesystem" => CodebaseType.Filesystem,
                "git" => CodebaseType.Git,
                "item" => CodebaseType.Item,
                "local" => CodebaseType.Local,
                _ => null,
            };
        }
    }
}