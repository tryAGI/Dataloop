
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PaymentDriverType
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
        Stripe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PaymentDriverTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PaymentDriverType value)
        {
            return value switch
            {
                PaymentDriverType.AzureMarketplace => "azureMarketplace",
                PaymentDriverType.Credits => "credits",
                PaymentDriverType.Stripe => "stripe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PaymentDriverType? ToEnum(string value)
        {
            return value switch
            {
                "azureMarketplace" => PaymentDriverType.AzureMarketplace,
                "credits" => PaymentDriverType.Credits,
                "stripe" => PaymentDriverType.Stripe,
                _ => null,
            };
        }
    }
}