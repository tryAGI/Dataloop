
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum KubernetesServiceType
    {
        /// <summary>
        /// 
        /// </summary>
        ClusterIP,
        /// <summary>
        /// 
        /// </summary>
        LoadBalancer,
        /// <summary>
        /// 
        /// </summary>
        NodePort,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KubernetesServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KubernetesServiceType value)
        {
            return value switch
            {
                KubernetesServiceType.ClusterIP => "ClusterIP",
                KubernetesServiceType.LoadBalancer => "LoadBalancer",
                KubernetesServiceType.NodePort => "NodePort",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KubernetesServiceType? ToEnum(string value)
        {
            return value switch
            {
                "ClusterIP" => KubernetesServiceType.ClusterIP,
                "LoadBalancer" => KubernetesServiceType.LoadBalancer,
                "NodePort" => KubernetesServiceType.NodePort,
                _ => null,
            };
        }
    }
}