
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum BenchmarkIngestionStrategyType
    {
        /// <summary>
        /// 
        /// </summary>
        Batch,
        /// <summary>
        /// 
        /// </summary>
        Sequentially,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BenchmarkIngestionStrategyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BenchmarkIngestionStrategyType value)
        {
            return value switch
            {
                BenchmarkIngestionStrategyType.Batch => "batch",
                BenchmarkIngestionStrategyType.Sequentially => "sequentially",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BenchmarkIngestionStrategyType? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BenchmarkIngestionStrategyType.Batch,
                "sequentially" => BenchmarkIngestionStrategyType.Sequentially,
                _ => null,
            };
        }
    }
}