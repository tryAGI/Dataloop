
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConcurrencyBenchmarkModeType
    {
        /// <summary>
        /// 
        /// </summary>
        Concurrency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConcurrencyBenchmarkModeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConcurrencyBenchmarkModeType value)
        {
            return value switch
            {
                ConcurrencyBenchmarkModeType.Concurrency => "concurrency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConcurrencyBenchmarkModeType? ToEnum(string value)
        {
            return value switch
            {
                "concurrency" => ConcurrencyBenchmarkModeType.Concurrency,
                _ => null,
            };
        }
    }
}