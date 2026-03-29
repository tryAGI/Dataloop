
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetAccessLevel
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
    public static class DatasetAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetAccessLevel value)
        {
            return value switch
            {
                DatasetAccessLevel.Private => "private",
                DatasetAccessLevel.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "private" => DatasetAccessLevel.Private,
                "project" => DatasetAccessLevel.Project,
                _ => null,
            };
        }
    }
}