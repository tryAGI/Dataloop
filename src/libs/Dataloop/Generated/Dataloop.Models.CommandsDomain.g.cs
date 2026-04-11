
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CommandsDomain
    {
        /// <summary>
        /// 
        /// </summary>
        Billing,
        /// <summary>
        /// 
        /// </summary>
        Data,
        /// <summary>
        /// 
        /// </summary>
        Faas,
        /// <summary>
        /// 
        /// </summary>
        ModelManagement,
        /// <summary>
        /// 
        /// </summary>
        Settings,
        /// <summary>
        /// 
        /// </summary>
        Workflows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommandsDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommandsDomain value)
        {
            return value switch
            {
                CommandsDomain.Billing => "billing",
                CommandsDomain.Data => "data",
                CommandsDomain.Faas => "faas",
                CommandsDomain.ModelManagement => "model-management",
                CommandsDomain.Settings => "settings",
                CommandsDomain.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommandsDomain? ToEnum(string value)
        {
            return value switch
            {
                "billing" => CommandsDomain.Billing,
                "data" => CommandsDomain.Data,
                "faas" => CommandsDomain.Faas,
                "model-management" => CommandsDomain.ModelManagement,
                "settings" => CommandsDomain.Settings,
                "workflows" => CommandsDomain.Workflows,
                _ => null,
            };
        }
    }
}