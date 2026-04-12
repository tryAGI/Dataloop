
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackageConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Codebase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackageConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackageConfigType value)
        {
            return value switch
            {
                PackageConfigType.Code => "code",
                PackageConfigType.Codebase => "codebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackageConfigType? ToEnum(string value)
        {
            return value switch
            {
                "code" => PackageConfigType.Code,
                "codebase" => PackageConfigType.Codebase,
                _ => null,
            };
        }
    }
}