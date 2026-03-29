
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssignmentMetadataSystemType
    {
        /// <summary>
        /// 
        /// </summary>
        Bucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssignmentMetadataSystemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignmentMetadataSystemType value)
        {
            return value switch
            {
                AssignmentMetadataSystemType.Bucket => "bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignmentMetadataSystemType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => AssignmentMetadataSystemType.Bucket,
                _ => null,
            };
        }
    }
}