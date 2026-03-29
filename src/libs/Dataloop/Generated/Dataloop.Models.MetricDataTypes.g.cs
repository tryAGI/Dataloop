
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetricDataTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Line,
        /// <summary>
        /// 
        /// </summary>
        Matrix,
        /// <summary>
        /// 
        /// </summary>
        Summary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetricDataTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricDataTypes value)
        {
            return value switch
            {
                MetricDataTypes.Line => "line",
                MetricDataTypes.Matrix => "matrix",
                MetricDataTypes.Summary => "summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricDataTypes? ToEnum(string value)
        {
            return value switch
            {
                "line" => MetricDataTypes.Line,
                "matrix" => MetricDataTypes.Matrix,
                "summary" => MetricDataTypes.Summary,
                _ => null,
            };
        }
    }
}