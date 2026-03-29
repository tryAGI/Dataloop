
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExportErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        Cmd,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportErrorType value)
        {
            return value switch
            {
                ExportErrorType.Cmd => "cmd",
                ExportErrorType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportErrorType? ToEnum(string value)
        {
            return value switch
            {
                "cmd" => ExportErrorType.Cmd,
                "timeout" => ExportErrorType.Timeout,
                _ => null,
            };
        }
    }
}