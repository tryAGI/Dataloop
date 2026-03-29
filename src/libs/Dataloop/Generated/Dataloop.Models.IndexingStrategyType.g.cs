
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum IndexingStrategyType
    {
        /// <summary>
        /// 
        /// </summary>
        SeekableJSON,
        /// <summary>
        /// 
        /// </summary>
        SeekableLZ4,
        /// <summary>
        /// 
        /// </summary>
        Indexed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexingStrategyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexingStrategyType value)
        {
            return value switch
            {
                IndexingStrategyType.SeekableJSON => "SeekableJSON",
                IndexingStrategyType.SeekableLZ4 => "SeekableLZ4",
                IndexingStrategyType.Indexed => "indexed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexingStrategyType? ToEnum(string value)
        {
            return value switch
            {
                "SeekableJSON" => IndexingStrategyType.SeekableJSON,
                "SeekableLZ4" => IndexingStrategyType.SeekableLZ4,
                "indexed" => IndexingStrategyType.Indexed,
                _ => null,
            };
        }
    }
}