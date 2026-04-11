
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackageType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Faas,
        /// <summary>
        /// 
        /// </summary>
        Ml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackageType value)
        {
            return value switch
            {
                PackageType.App => "app",
                PackageType.Faas => "faas",
                PackageType.Ml => "ml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackageType? ToEnum(string value)
        {
            return value switch
            {
                "app" => PackageType.App,
                "faas" => PackageType.Faas,
                "ml" => PackageType.Ml,
                _ => null,
            };
        }
    }
}