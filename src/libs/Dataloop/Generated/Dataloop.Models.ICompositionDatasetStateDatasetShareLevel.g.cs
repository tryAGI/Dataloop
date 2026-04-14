
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ICompositionDatasetStateDatasetShareLevel
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
    public static class ICompositionDatasetStateDatasetShareLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ICompositionDatasetStateDatasetShareLevel value)
        {
            return value switch
            {
                ICompositionDatasetStateDatasetShareLevel.Private => "private",
                ICompositionDatasetStateDatasetShareLevel.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ICompositionDatasetStateDatasetShareLevel? ToEnum(string value)
        {
            return value switch
            {
                "private" => ICompositionDatasetStateDatasetShareLevel.Private,
                "project" => ICompositionDatasetStateDatasetShareLevel.Project,
                _ => null,
            };
        }
    }
}