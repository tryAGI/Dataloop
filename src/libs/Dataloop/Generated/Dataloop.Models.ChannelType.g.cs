
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChannelType
    {
        /// <summary>
        /// 
        /// </summary>
        Application,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelType value)
        {
            return value switch
            {
                ChannelType.Application => "application",
                ChannelType.Email => "email",
                ChannelType.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelType? ToEnum(string value)
        {
            return value switch
            {
                "application" => ChannelType.Application,
                "email" => ChannelType.Email,
                "internal" => ChannelType.Internal,
                _ => null,
            };
        }
    }
}