
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Acknowledged,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        EmailSent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertStatus value)
        {
            return value switch
            {
                AlertStatus.Acknowledged => "acknowledged",
                AlertStatus.Closed => "closed",
                AlertStatus.Created => "created",
                AlertStatus.EmailSent => "emailSent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertStatus? ToEnum(string value)
        {
            return value switch
            {
                "acknowledged" => AlertStatus.Acknowledged,
                "closed" => AlertStatus.Closed,
                "created" => AlertStatus.Created,
                "emailSent" => AlertStatus.EmailSent,
                _ => null,
            };
        }
    }
}