
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelOutputTypeVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Embedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOutputTypeVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOutputTypeVariant4 value)
        {
            return value switch
            {
                ModelOutputTypeVariant4.Embedding => "embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOutputTypeVariant4? ToEnum(string value)
        {
            return value switch
            {
                "embedding" => ModelOutputTypeVariant4.Embedding,
                _ => null,
            };
        }
    }
}