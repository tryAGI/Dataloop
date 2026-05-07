
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResourceAuditEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResourceAuditEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceAuditEventType value)
        {
            return value switch
            {
                ResourceAuditEventType.Created => "created",
                ResourceAuditEventType.Deleted => "deleted",
                ResourceAuditEventType.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceAuditEventType? ToEnum(string value)
        {
            return value switch
            {
                "created" => ResourceAuditEventType.Created,
                "deleted" => ResourceAuditEventType.Deleted,
                "updated" => ResourceAuditEventType.Updated,
                _ => null,
            };
        }
    }
}