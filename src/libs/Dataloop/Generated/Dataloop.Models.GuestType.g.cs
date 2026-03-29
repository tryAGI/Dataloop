
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum GuestType
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Labeling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuestType value)
        {
            return value switch
            {
                GuestType.Development => "development",
                GuestType.Labeling => "labeling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuestType? ToEnum(string value)
        {
            return value switch
            {
                "development" => GuestType.Development,
                "labeling" => GuestType.Labeling,
                _ => null,
            };
        }
    }
}