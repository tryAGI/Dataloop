
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum TriggerActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Clone,
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
        /// <summary>
        /// 
        /// </summary>
        StatusChanged,
        /// <summary>
        /// 
        /// </summary>
        TaskAssigned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerActionType value)
        {
            return value switch
            {
                TriggerActionType.Clone => "Clone",
                TriggerActionType.Created => "Created",
                TriggerActionType.Deleted => "Deleted",
                TriggerActionType.Updated => "Updated",
                TriggerActionType.StatusChanged => "statusChanged",
                TriggerActionType.TaskAssigned => "taskAssigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerActionType? ToEnum(string value)
        {
            return value switch
            {
                "Clone" => TriggerActionType.Clone,
                "Created" => TriggerActionType.Created,
                "Deleted" => TriggerActionType.Deleted,
                "Updated" => TriggerActionType.Updated,
                "statusChanged" => TriggerActionType.StatusChanged,
                "taskAssigned" => TriggerActionType.TaskAssigned,
                _ => null,
            };
        }
    }
}