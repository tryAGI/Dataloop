
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Tracks which gateway was last deployed in front of serve-agent.<br/>
    /// Used to cleanup the previous gateway when switching between Nginx gateway and direct access.
    /// </summary>
    public enum ComputeMetadataVariant2ServeAgentGateway
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        NginxGateway,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputeMetadataVariant2ServeAgentGatewayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputeMetadataVariant2ServeAgentGateway value)
        {
            return value switch
            {
                ComputeMetadataVariant2ServeAgentGateway.Direct => "direct",
                ComputeMetadataVariant2ServeAgentGateway.NginxGateway => "nginx-gateway",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputeMetadataVariant2ServeAgentGateway? ToEnum(string value)
        {
            return value switch
            {
                "direct" => ComputeMetadataVariant2ServeAgentGateway.Direct,
                "nginx-gateway" => ComputeMetadataVariant2ServeAgentGateway.NginxGateway,
                _ => null,
            };
        }
    }
}