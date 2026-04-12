
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum TriggerOperationType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Pipeline,
        /// <summary>
        /// 
        /// </summary>
        Rabbitmq,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerOperationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerOperationType value)
        {
            return value switch
            {
                TriggerOperationType.Function => "function",
                TriggerOperationType.Pipeline => "pipeline",
                TriggerOperationType.Rabbitmq => "rabbitmq",
                TriggerOperationType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerOperationType? ToEnum(string value)
        {
            return value switch
            {
                "function" => TriggerOperationType.Function,
                "pipeline" => TriggerOperationType.Pipeline,
                "rabbitmq" => TriggerOperationType.Rabbitmq,
                "webhook" => TriggerOperationType.Webhook,
                _ => null,
            };
        }
    }
}