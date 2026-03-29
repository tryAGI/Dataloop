
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum OneByOneLatencyBenchmarkModeType
    {
        /// <summary>
        /// 
        /// </summary>
        OneByOneLatency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OneByOneLatencyBenchmarkModeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OneByOneLatencyBenchmarkModeType value)
        {
            return value switch
            {
                OneByOneLatencyBenchmarkModeType.OneByOneLatency => "oneByOneLatency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OneByOneLatencyBenchmarkModeType? ToEnum(string value)
        {
            return value switch
            {
                "oneByOneLatency" => OneByOneLatencyBenchmarkModeType.OneByOneLatency,
                _ => null,
            };
        }
    }
}