
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum NodeType
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Merge,
        /// <summary>
        /// 
        /// </summary>
        Ml,
        /// <summary>
        /// 
        /// </summary>
        Split,
        /// <summary>
        /// 
        /// </summary>
        Storage,
        /// <summary>
        /// 
        /// </summary>
        Task,
        /// <summary>
        /// 
        /// </summary>
        UpdateVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeType value)
        {
            return value switch
            {
                NodeType.Api => "api",
                NodeType.Code => "code",
                NodeType.Custom => "custom",
                NodeType.Function => "function",
                NodeType.Merge => "merge",
                NodeType.Ml => "ml",
                NodeType.Split => "split",
                NodeType.Storage => "storage",
                NodeType.Task => "task",
                NodeType.UpdateVariable => "updateVariable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeType? ToEnum(string value)
        {
            return value switch
            {
                "api" => NodeType.Api,
                "code" => NodeType.Code,
                "custom" => NodeType.Custom,
                "function" => NodeType.Function,
                "merge" => NodeType.Merge,
                "ml" => NodeType.Ml,
                "split" => NodeType.Split,
                "storage" => NodeType.Storage,
                "task" => NodeType.Task,
                "updateVariable" => NodeType.UpdateVariable,
                _ => null,
            };
        }
    }
}