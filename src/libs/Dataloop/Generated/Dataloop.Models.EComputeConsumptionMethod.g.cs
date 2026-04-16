
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EComputeConsumptionMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Mq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EComputeConsumptionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EComputeConsumptionMethod value)
        {
            return value switch
            {
                EComputeConsumptionMethod.Api => "API",
                EComputeConsumptionMethod.Mq => "MQ",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EComputeConsumptionMethod? ToEnum(string value)
        {
            return value switch
            {
                "API" => EComputeConsumptionMethod.Api,
                "MQ" => EComputeConsumptionMethod.Mq,
                _ => null,
            };
        }
    }
}