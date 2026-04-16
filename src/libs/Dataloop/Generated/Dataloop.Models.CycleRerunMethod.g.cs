
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CycleRerunMethod
    {
        /// <summary>
        /// 
        /// </summary>
        StartFromBeginning,
        /// <summary>
        /// 
        /// </summary>
        StartFromFailedExecutions,
        /// <summary>
        /// 
        /// </summary>
        StartFromNodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CycleRerunMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CycleRerunMethod value)
        {
            return value switch
            {
                CycleRerunMethod.StartFromBeginning => "startFromBeginning",
                CycleRerunMethod.StartFromFailedExecutions => "startFromFailedExecutions",
                CycleRerunMethod.StartFromNodes => "startFromNodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CycleRerunMethod? ToEnum(string value)
        {
            return value switch
            {
                "startFromBeginning" => CycleRerunMethod.StartFromBeginning,
                "startFromFailedExecutions" => CycleRerunMethod.StartFromFailedExecutions,
                "startFromNodes" => CycleRerunMethod.StartFromNodes,
                _ => null,
            };
        }
    }
}