
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EClusterProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Aws,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        Gcp,
        /// <summary>
        /// 
        /// </summary>
        Hpc,
        /// <summary>
        /// 
        /// </summary>
        Local,
        /// <summary>
        /// 
        /// </summary>
        Openshift,
        /// <summary>
        /// 
        /// </summary>
        RancherK3s,
        /// <summary>
        /// 
        /// </summary>
        RancherRke,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EClusterProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EClusterProvider value)
        {
            return value switch
            {
                EClusterProvider.Aws => "aws",
                EClusterProvider.Azure => "azure",
                EClusterProvider.Gcp => "gcp",
                EClusterProvider.Hpc => "hpc",
                EClusterProvider.Local => "local",
                EClusterProvider.Openshift => "openshift",
                EClusterProvider.RancherK3s => "rancher-k3s",
                EClusterProvider.RancherRke => "rancher-rke",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EClusterProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => EClusterProvider.Aws,
                "azure" => EClusterProvider.Azure,
                "gcp" => EClusterProvider.Gcp,
                "hpc" => EClusterProvider.Hpc,
                "local" => EClusterProvider.Local,
                "openshift" => EClusterProvider.Openshift,
                "rancher-k3s" => EClusterProvider.RancherK3s,
                "rancher-rke" => EClusterProvider.RancherRke,
                _ => null,
            };
        }
    }
}