
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum BillingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Blocked,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Future,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Renewed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingStatus value)
        {
            return value switch
            {
                BillingStatus.Active => "active",
                BillingStatus.Blocked => "blocked",
                BillingStatus.Canceled => "canceled",
                BillingStatus.Expired => "expired",
                BillingStatus.Future => "future",
                BillingStatus.Paused => "paused",
                BillingStatus.Renewed => "renewed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => BillingStatus.Active,
                "blocked" => BillingStatus.Blocked,
                "canceled" => BillingStatus.Canceled,
                "expired" => BillingStatus.Expired,
                "future" => BillingStatus.Future,
                "paused" => BillingStatus.Paused,
                "renewed" => BillingStatus.Renewed,
                _ => null,
            };
        }
    }
}