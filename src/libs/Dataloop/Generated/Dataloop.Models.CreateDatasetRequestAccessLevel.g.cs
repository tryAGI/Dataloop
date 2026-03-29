
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Share options, only user or all project members with the right role (default is project)
    /// </summary>
    public enum CreateDatasetRequestAccessLevel
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
    public static class CreateDatasetRequestAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetRequestAccessLevel value)
        {
            return value switch
            {
                CreateDatasetRequestAccessLevel.Private => "private",
                CreateDatasetRequestAccessLevel.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetRequestAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateDatasetRequestAccessLevel.Private,
                "project" => CreateDatasetRequestAccessLevel.Project,
                _ => null,
            };
        }
    }
}