
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionPostActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Download,
        /// <summary>
        /// 
        /// </summary>
        DrawAnnotation,
        /// <summary>
        /// 
        /// </summary>
        NoAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionPostActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionPostActionType value)
        {
            return value switch
            {
                ExecutionPostActionType.Download => "download",
                ExecutionPostActionType.DrawAnnotation => "drawAnnotation",
                ExecutionPostActionType.NoAction => "noAction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionPostActionType? ToEnum(string value)
        {
            return value switch
            {
                "download" => ExecutionPostActionType.Download,
                "drawAnnotation" => ExecutionPostActionType.DrawAnnotation,
                "noAction" => ExecutionPostActionType.NoAction,
                _ => null,
            };
        }
    }
}