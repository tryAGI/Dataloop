
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DBPaymentDriverConfigurationType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureMarketplace,
        /// <summary>
        /// 
        /// </summary>
        Credits,
        /// <summary>
        /// 
        /// </summary>
        Nop,
        /// <summary>
        /// 
        /// </summary>
        Stripe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DBPaymentDriverConfigurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DBPaymentDriverConfigurationType value)
        {
            return value switch
            {
                DBPaymentDriverConfigurationType.AzureMarketplace => "azureMarketplace",
                DBPaymentDriverConfigurationType.Credits => "credits",
                DBPaymentDriverConfigurationType.Nop => "nop",
                DBPaymentDriverConfigurationType.Stripe => "stripe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DBPaymentDriverConfigurationType? ToEnum(string value)
        {
            return value switch
            {
                "azureMarketplace" => DBPaymentDriverConfigurationType.AzureMarketplace,
                "credits" => DBPaymentDriverConfigurationType.Credits,
                "nop" => DBPaymentDriverConfigurationType.Nop,
                "stripe" => DBPaymentDriverConfigurationType.Stripe,
                _ => null,
            };
        }
    }
}