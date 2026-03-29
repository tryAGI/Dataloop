
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum NodeMlType
    {
        /// <summary>
        /// 
        /// </summary>
        Embeddings,
        /// <summary>
        /// 
        /// </summary>
        GenAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeMlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeMlType value)
        {
            return value switch
            {
                NodeMlType.Embeddings => "embeddings",
                NodeMlType.GenAi => "genAi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeMlType? ToEnum(string value)
        {
            return value switch
            {
                "embeddings" => NodeMlType.Embeddings,
                "genAi" => NodeMlType.GenAi,
                _ => null,
            };
        }
    }
}