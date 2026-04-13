
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelOutputTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Embedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOutputTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOutputTypeEnum value)
        {
            return value switch
            {
                ModelOutputTypeEnum.Embedding => "embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOutputTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "embedding" => ModelOutputTypeEnum.Embedding,
                _ => null,
            };
        }
    }
}