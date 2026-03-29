
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum BillingPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        Annual,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingPeriod value)
        {
            return value switch
            {
                BillingPeriod.Annual => "annual",
                BillingPeriod.Custom => "custom",
                BillingPeriod.Monthly => "monthly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingPeriod? ToEnum(string value)
        {
            return value switch
            {
                "annual" => BillingPeriod.Annual,
                "custom" => BillingPeriod.Custom,
                "monthly" => BillingPeriod.Monthly,
                _ => null,
            };
        }
    }
}