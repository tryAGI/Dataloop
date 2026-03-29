
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ItemSpecType
    {
        /// <summary>
        /// 
        /// </summary>
        ClonedItemSpec,
        /// <summary>
        /// 
        /// </summary>
        MasterItemSpec,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ItemSpecTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemSpecType value)
        {
            return value switch
            {
                ItemSpecType.ClonedItemSpec => "ClonedItemSpec",
                ItemSpecType.MasterItemSpec => "MasterItemSpec",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemSpecType? ToEnum(string value)
        {
            return value switch
            {
                "ClonedItemSpec" => ItemSpecType.ClonedItemSpec,
                "MasterItemSpec" => ItemSpecType.MasterItemSpec,
                _ => null,
            };
        }
    }
}