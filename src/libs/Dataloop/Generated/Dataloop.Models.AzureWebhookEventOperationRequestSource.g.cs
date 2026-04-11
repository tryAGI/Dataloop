
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AzureWebhookEventOperationRequestSource
    {
        /// <summary>
        /// 
        /// </summary>
        Azure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureWebhookEventOperationRequestSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureWebhookEventOperationRequestSource value)
        {
            return value switch
            {
                AzureWebhookEventOperationRequestSource.Azure => "Azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureWebhookEventOperationRequestSource? ToEnum(string value)
        {
            return value switch
            {
                "Azure" => AzureWebhookEventOperationRequestSource.Azure,
                _ => null,
            };
        }
    }
}