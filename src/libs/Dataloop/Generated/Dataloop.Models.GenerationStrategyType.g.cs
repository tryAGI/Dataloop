
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerationStrategyType
    {
        /// <summary>
        /// 
        /// </summary>
        Parallel,
        /// <summary>
        /// 
        /// </summary>
        Sequentially,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationStrategyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationStrategyType value)
        {
            return value switch
            {
                GenerationStrategyType.Parallel => "parallel",
                GenerationStrategyType.Sequentially => "sequentially",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationStrategyType? ToEnum(string value)
        {
            return value switch
            {
                "parallel" => GenerationStrategyType.Parallel,
                "sequentially" => GenerationStrategyType.Sequentially,
                _ => null,
            };
        }
    }
}