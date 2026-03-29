
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum APIDatasetAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class APIDatasetAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APIDatasetAccessLevel value)
        {
            return value switch
            {
                APIDatasetAccessLevel.Private => "private",
                APIDatasetAccessLevel.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APIDatasetAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "private" => APIDatasetAccessLevel.Private,
                "project" => APIDatasetAccessLevel.Project,
                _ => null,
            };
        }
    }
}