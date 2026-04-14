
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum TriggerResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        Assignment,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Item,
        /// <summary>
        /// 
        /// </summary>
        ItemStatus,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Task,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerResourceType value)
        {
            return value switch
            {
                TriggerResourceType.Annotation => "Annotation",
                TriggerResourceType.Assignment => "Assignment",
                TriggerResourceType.Dataset => "Dataset",
                TriggerResourceType.Item => "Item",
                TriggerResourceType.ItemStatus => "ItemStatus",
                TriggerResourceType.Model => "Model",
                TriggerResourceType.Task => "Task",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerResourceType? ToEnum(string value)
        {
            return value switch
            {
                "Annotation" => TriggerResourceType.Annotation,
                "Assignment" => TriggerResourceType.Assignment,
                "Dataset" => TriggerResourceType.Dataset,
                "Item" => TriggerResourceType.Item,
                "ItemStatus" => TriggerResourceType.ItemStatus,
                "Model" => TriggerResourceType.Model,
                "Task" => TriggerResourceType.Task,
                _ => null,
            };
        }
    }
}