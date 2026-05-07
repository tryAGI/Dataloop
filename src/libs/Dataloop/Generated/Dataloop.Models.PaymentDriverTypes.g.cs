
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PaymentDriverTypes
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
    public static class PaymentDriverTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PaymentDriverTypes value)
        {
            return value switch
            {
                PaymentDriverTypes.AzureMarketplace => "azureMarketplace",
                PaymentDriverTypes.Credits => "credits",
                PaymentDriverTypes.Nop => "nop",
                PaymentDriverTypes.Stripe => "stripe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PaymentDriverTypes? ToEnum(string value)
        {
            return value switch
            {
                "azureMarketplace" => PaymentDriverTypes.AzureMarketplace,
                "credits" => PaymentDriverTypes.Credits,
                "nop" => PaymentDriverTypes.Nop,
                "stripe" => PaymentDriverTypes.Stripe,
                _ => null,
            };
        }
    }
}