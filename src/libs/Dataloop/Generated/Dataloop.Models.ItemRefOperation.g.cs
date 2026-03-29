
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ItemRefOperation
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
    public static class ItemRefOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemRefOperation value)
        {
            return value switch
            {
                ItemRefOperation.Create => "create",
                ItemRefOperation.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemRefOperation? ToEnum(string value)
        {
            return value switch
            {
                "create" => ItemRefOperation.Create,
                "delete" => ItemRefOperation.Delete,
                _ => null,
            };
        }
    }
}