
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertTier
    {
        /// <summary>
        /// 
        /// </summary>
        Acute,
        /// <summary>
        /// 
        /// </summary>
        Early,
        /// <summary>
        /// 
        /// </summary>
        Enforcement,
        /// <summary>
        /// 
        /// </summary>
        Preliminary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertTier value)
        {
            return value switch
            {
                AlertTier.Acute => "acute",
                AlertTier.Early => "early",
                AlertTier.Enforcement => "enforcement",
                AlertTier.Preliminary => "preliminary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertTier? ToEnum(string value)
        {
            return value switch
            {
                "acute" => AlertTier.Acute,
                "early" => AlertTier.Early,
                "enforcement" => AlertTier.Enforcement,
                "preliminary" => AlertTier.Preliminary,
                _ => null,
            };
        }
    }
}