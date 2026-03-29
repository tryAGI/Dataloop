
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExportStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportStatus value)
        {
            return value switch
            {
                ExportStatus.Failed => "failed",
                ExportStatus.InProgress => "in-progress",
                ExportStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ExportStatus.Failed,
                "in-progress" => ExportStatus.InProgress,
                "success" => ExportStatus.Success,
                _ => null,
            };
        }
    }
}