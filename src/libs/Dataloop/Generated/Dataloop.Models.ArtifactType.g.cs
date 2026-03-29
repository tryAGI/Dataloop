
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ArtifactType
    {
        /// <summary>
        /// 
        /// </summary>
        Item,
        /// <summary>
        /// 
        /// </summary>
        Link,
        /// <summary>
        /// 
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArtifactTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArtifactType value)
        {
            return value switch
            {
                ArtifactType.Item => "item",
                ArtifactType.Link => "link",
                ArtifactType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArtifactType? ToEnum(string value)
        {
            return value switch
            {
                "item" => ArtifactType.Item,
                "link" => ArtifactType.Link,
                "local" => ArtifactType.Local,
                _ => null,
            };
        }
    }
}