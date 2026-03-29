
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// command will execute query profile for each test case
    /// </summary>
    public enum ProfilingBenchmarkModeType
    {
        /// <summary>
        /// 
        /// </summary>
        Profiling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilingBenchmarkModeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilingBenchmarkModeType value)
        {
            return value switch
            {
                ProfilingBenchmarkModeType.Profiling => "profiling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilingBenchmarkModeType? ToEnum(string value)
        {
            return value switch
            {
                "profiling" => ProfilingBenchmarkModeType.Profiling,
                _ => null,
            };
        }
    }
}