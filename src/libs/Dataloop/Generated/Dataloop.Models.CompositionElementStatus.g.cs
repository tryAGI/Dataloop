
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompositionElementStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Attached,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Installed,
        /// <summary>
        /// 
        /// </summary>
        Pause,
        /// <summary>
        /// 
        /// </summary>
        Resume,
        /// <summary>
        /// 
        /// </summary>
        Uninstalled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompositionElementStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompositionElementStatus value)
        {
            return value switch
            {
                CompositionElementStatus.Attached => "attached",
                CompositionElementStatus.Failed => "failed",
                CompositionElementStatus.Installed => "installed",
                CompositionElementStatus.Pause => "pause",
                CompositionElementStatus.Resume => "resume",
                CompositionElementStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompositionElementStatus? ToEnum(string value)
        {
            return value switch
            {
                "attached" => CompositionElementStatus.Attached,
                "failed" => CompositionElementStatus.Failed,
                "installed" => CompositionElementStatus.Installed,
                "pause" => CompositionElementStatus.Pause,
                "resume" => CompositionElementStatus.Resume,
                "uninstalled" => CompositionElementStatus.Uninstalled,
                _ => null,
            };
        }
    }
}