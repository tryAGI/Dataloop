
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterFrequencyType
    {
        /// <summary>
        /// 
        /// </summary>
        Rate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterFrequencyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterFrequencyType value)
        {
            return value switch
            {
                FilterFrequencyType.Rate => "rate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterFrequencyType? ToEnum(string value)
        {
            return value switch
            {
                "rate" => FilterFrequencyType.Rate,
                _ => null,
            };
        }
    }
}