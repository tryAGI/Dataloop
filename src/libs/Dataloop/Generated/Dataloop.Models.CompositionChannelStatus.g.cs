
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompositionChannelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Uninstalled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompositionChannelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompositionChannelStatus value)
        {
            return value switch
            {
                CompositionChannelStatus.Active => "active",
                CompositionChannelStatus.Created => "created",
                CompositionChannelStatus.Failed => "failed",
                CompositionChannelStatus.Paused => "paused",
                CompositionChannelStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompositionChannelStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CompositionChannelStatus.Active,
                "created" => CompositionChannelStatus.Created,
                "failed" => CompositionChannelStatus.Failed,
                "paused" => CompositionChannelStatus.Paused,
                "uninstalled" => CompositionChannelStatus.Uninstalled,
                _ => null,
            };
        }
    }
}