
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EComputeType
    {
        /// <summary>
        /// 
        /// </summary>
        Kubernetes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EComputeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EComputeType value)
        {
            return value switch
            {
                EComputeType.Kubernetes => "kubernetes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EComputeType? ToEnum(string value)
        {
            return value switch
            {
                "kubernetes" => EComputeType.Kubernetes,
                _ => null,
            };
        }
    }
}