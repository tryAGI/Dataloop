
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum Role
    {
        /// <summary>
        /// 
        /// </summary>
        AnnotationManager,
        /// <summary>
        /// 
        /// </summary>
        Annotator,
        /// <summary>
        /// 
        /// </summary>
        Engineer,
        /// <summary>
        /// 
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Role value)
        {
            return value switch
            {
                Role.AnnotationManager => "annotationManager",
                Role.Annotator => "annotator",
                Role.Engineer => "engineer",
                Role.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Role? ToEnum(string value)
        {
            return value switch
            {
                "annotationManager" => Role.AnnotationManager,
                "annotator" => Role.Annotator,
                "engineer" => Role.Engineer,
                "owner" => Role.Owner,
                _ => null,
            };
        }
    }
}