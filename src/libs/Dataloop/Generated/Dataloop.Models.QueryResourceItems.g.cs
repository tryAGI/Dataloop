
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryResourceItems
    {
        /// <summary>
        /// 
        /// </summary>
        Items,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryResourceItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryResourceItems value)
        {
            return value switch
            {
                QueryResourceItems.Items => "items",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryResourceItems? ToEnum(string value)
        {
            return value switch
            {
                "items" => QueryResourceItems.Items,
                _ => null,
            };
        }
    }
}