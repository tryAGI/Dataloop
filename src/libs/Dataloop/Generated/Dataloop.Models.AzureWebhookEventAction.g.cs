
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AzureWebhookEventAction
    {
        /// <summary>
        /// 
        /// </summary>
        ChangePlan,
        /// <summary>
        /// 
        /// </summary>
        ChangeQuantity,
        /// <summary>
        /// 
        /// </summary>
        Reinstate,
        /// <summary>
        /// 
        /// </summary>
        Renew,
        /// <summary>
        /// 
        /// </summary>
        Suspend,
        /// <summary>
        /// 
        /// </summary>
        Unsubscribe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureWebhookEventActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureWebhookEventAction value)
        {
            return value switch
            {
                AzureWebhookEventAction.ChangePlan => "ChangePlan",
                AzureWebhookEventAction.ChangeQuantity => "ChangeQuantity",
                AzureWebhookEventAction.Reinstate => "Reinstate",
                AzureWebhookEventAction.Renew => "Renew",
                AzureWebhookEventAction.Suspend => "Suspend",
                AzureWebhookEventAction.Unsubscribe => "Unsubscribe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureWebhookEventAction? ToEnum(string value)
        {
            return value switch
            {
                "ChangePlan" => AzureWebhookEventAction.ChangePlan,
                "ChangeQuantity" => AzureWebhookEventAction.ChangeQuantity,
                "Reinstate" => AzureWebhookEventAction.Reinstate,
                "Renew" => AzureWebhookEventAction.Renew,
                "Suspend" => AzureWebhookEventAction.Suspend,
                "Unsubscribe" => AzureWebhookEventAction.Unsubscribe,
                _ => null,
            };
        }
    }
}