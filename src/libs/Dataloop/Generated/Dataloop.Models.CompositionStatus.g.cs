
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompositionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Activated,
        /// <summary>
        /// 
        /// </summary>
        ActiveTest,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deactivated,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Initializing,
        /// <summary>
        /// 
        /// </summary>
        Installed,
        /// <summary>
        /// 
        /// </summary>
        Reconfiguring,
        /// <summary>
        /// 
        /// </summary>
        Terminated,
        /// <summary>
        /// 
        /// </summary>
        Terminating,
        /// <summary>
        /// 
        /// </summary>
        Uninstalled,
        /// <summary>
        /// 
        /// </summary>
        Updating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompositionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompositionStatus value)
        {
            return value switch
            {
                CompositionStatus.Activated => "Activated",
                CompositionStatus.ActiveTest => "ActiveTest",
                CompositionStatus.Created => "Created",
                CompositionStatus.Deactivated => "Deactivated",
                CompositionStatus.Failure => "Failure",
                CompositionStatus.Initializing => "Initializing",
                CompositionStatus.Installed => "Installed",
                CompositionStatus.Reconfiguring => "Reconfiguring",
                CompositionStatus.Terminated => "Terminated",
                CompositionStatus.Terminating => "Terminating",
                CompositionStatus.Uninstalled => "Uninstalled",
                CompositionStatus.Updating => "Updating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompositionStatus? ToEnum(string value)
        {
            return value switch
            {
                "Activated" => CompositionStatus.Activated,
                "ActiveTest" => CompositionStatus.ActiveTest,
                "Created" => CompositionStatus.Created,
                "Deactivated" => CompositionStatus.Deactivated,
                "Failure" => CompositionStatus.Failure,
                "Initializing" => CompositionStatus.Initializing,
                "Installed" => CompositionStatus.Installed,
                "Reconfiguring" => CompositionStatus.Reconfiguring,
                "Terminated" => CompositionStatus.Terminated,
                "Terminating" => CompositionStatus.Terminating,
                "Uninstalled" => CompositionStatus.Uninstalled,
                "Updating" => CompositionStatus.Updating,
                _ => null,
            };
        }
    }
}