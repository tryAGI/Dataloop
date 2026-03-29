
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum SetTaskRefsBenchmarkInputOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Delete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SetTaskRefsBenchmarkInputOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetTaskRefsBenchmarkInputOperation value)
        {
            return value switch
            {
                SetTaskRefsBenchmarkInputOperation.Create => "create",
                SetTaskRefsBenchmarkInputOperation.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetTaskRefsBenchmarkInputOperation? ToEnum(string value)
        {
            return value switch
            {
                "create" => SetTaskRefsBenchmarkInputOperation.Create,
                "delete" => SetTaskRefsBenchmarkInputOperation.Delete,
                _ => null,
            };
        }
    }
}