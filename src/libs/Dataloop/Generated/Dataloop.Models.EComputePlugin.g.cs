
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EComputePlugin
    {
        /// <summary>
        /// 
        /// </summary>
        Fluentd,
        /// <summary>
        /// 
        /// </summary>
        Grafana,
        /// <summary>
        /// 
        /// </summary>
        Keda,
        /// <summary>
        /// 
        /// </summary>
        Mirrors,
        /// <summary>
        /// 
        /// </summary>
        Monitoring,
        /// <summary>
        /// 
        /// </summary>
        Nfs,
        /// <summary>
        /// 
        /// </summary>
        NginxGateway,
        /// <summary>
        /// 
        /// </summary>
        NodeExporter,
        /// <summary>
        /// 
        /// </summary>
        Scaler,
        /// <summary>
        /// 
        /// </summary>
        StorageDriver,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EComputePluginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EComputePlugin value)
        {
            return value switch
            {
                EComputePlugin.Fluentd => "fluentd",
                EComputePlugin.Grafana => "grafana",
                EComputePlugin.Keda => "keda",
                EComputePlugin.Mirrors => "mirrors",
                EComputePlugin.Monitoring => "monitoring",
                EComputePlugin.Nfs => "nfs",
                EComputePlugin.NginxGateway => "nginx-gateway",
                EComputePlugin.NodeExporter => "node-exporter",
                EComputePlugin.Scaler => "scaler",
                EComputePlugin.StorageDriver => "storage-driver",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EComputePlugin? ToEnum(string value)
        {
            return value switch
            {
                "fluentd" => EComputePlugin.Fluentd,
                "grafana" => EComputePlugin.Grafana,
                "keda" => EComputePlugin.Keda,
                "mirrors" => EComputePlugin.Mirrors,
                "monitoring" => EComputePlugin.Monitoring,
                "nfs" => EComputePlugin.Nfs,
                "nginx-gateway" => EComputePlugin.NginxGateway,
                "node-exporter" => EComputePlugin.NodeExporter,
                "scaler" => EComputePlugin.Scaler,
                "storage-driver" => EComputePlugin.StorageDriver,
                _ => null,
            };
        }
    }
}