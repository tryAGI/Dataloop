
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlatformEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        BillingOrg,
        /// <summary>
        /// 
        /// </summary>
        BillingProject,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        Task,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlatformEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlatformEntityType value)
        {
            return value switch
            {
                PlatformEntityType.BillingOrg => "billing-org",
                PlatformEntityType.BillingProject => "billing-project",
                PlatformEntityType.Dataset => "dataset",
                PlatformEntityType.Org => "org",
                PlatformEntityType.Project => "project",
                PlatformEntityType.Task => "task",
                PlatformEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlatformEntityType? ToEnum(string value)
        {
            return value switch
            {
                "billing-org" => PlatformEntityType.BillingOrg,
                "billing-project" => PlatformEntityType.BillingProject,
                "dataset" => PlatformEntityType.Dataset,
                "org" => PlatformEntityType.Org,
                "project" => PlatformEntityType.Project,
                "task" => PlatformEntityType.Task,
                "user" => PlatformEntityType.User,
                _ => null,
            };
        }
    }
}