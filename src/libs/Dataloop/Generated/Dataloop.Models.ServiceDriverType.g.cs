
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServiceDriverType
    {
        /// <summary>
        /// 
        /// </summary>
        FargateEks,
        /// <summary>
        /// 
        /// </summary>
        Kubernetes,
        /// <summary>
        /// 
        /// </summary>
        Mock,
        /// <summary>
        /// 
        /// </summary>
        Noop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceDriverTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceDriverType value)
        {
            return value switch
            {
                ServiceDriverType.FargateEks => "Fargate-EKS",
                ServiceDriverType.Kubernetes => "Kubernetes",
                ServiceDriverType.Mock => "Mock",
                ServiceDriverType.Noop => "Noop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceDriverType? ToEnum(string value)
        {
            return value switch
            {
                "Fargate-EKS" => ServiceDriverType.FargateEks,
                "Kubernetes" => ServiceDriverType.Kubernetes,
                "Mock" => ServiceDriverType.Mock,
                "Noop" => ServiceDriverType.Noop,
                _ => null,
            };
        }
    }
}