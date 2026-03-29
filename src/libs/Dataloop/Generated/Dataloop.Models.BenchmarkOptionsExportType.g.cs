
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum BenchmarkOptionsExportType
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Lance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BenchmarkOptionsExportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BenchmarkOptionsExportType value)
        {
            return value switch
            {
                BenchmarkOptionsExportType.Json => "json",
                BenchmarkOptionsExportType.Lance => "lance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BenchmarkOptionsExportType? ToEnum(string value)
        {
            return value switch
            {
                "json" => BenchmarkOptionsExportType.Json,
                "lance" => BenchmarkOptionsExportType.Lance,
                _ => null,
            };
        }
    }
}