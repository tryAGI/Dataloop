
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServiceLogLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        Debug,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceLogLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceLogLevel value)
        {
            return value switch
            {
                ServiceLogLevel.Critical => "CRITICAL",
                ServiceLogLevel.Debug => "DEBUG",
                ServiceLogLevel.Error => "ERROR",
                ServiceLogLevel.Info => "INFO",
                ServiceLogLevel.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceLogLevel? ToEnum(string value)
        {
            return value switch
            {
                "CRITICAL" => ServiceLogLevel.Critical,
                "DEBUG" => ServiceLogLevel.Debug,
                "ERROR" => ServiceLogLevel.Error,
                "INFO" => ServiceLogLevel.Info,
                "WARNING" => ServiceLogLevel.Warning,
                _ => null,
            };
        }
    }
}