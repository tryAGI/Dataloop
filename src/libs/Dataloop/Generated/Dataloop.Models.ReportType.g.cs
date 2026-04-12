
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReportType
    {
        /// <summary>
        /// 
        /// </summary>
        ExecutionStatus,
        /// <summary>
        /// 
        /// </summary>
        ServiceStatus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReportType value)
        {
            return value switch
            {
                ReportType.ExecutionStatus => "executionStatus",
                ReportType.ServiceStatus => "serviceStatus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReportType? ToEnum(string value)
        {
            return value switch
            {
                "executionStatus" => ReportType.ExecutionStatus,
                "serviceStatus" => ReportType.ServiceStatus,
                _ => null,
            };
        }
    }
}