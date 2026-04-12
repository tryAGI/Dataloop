
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EStorageType
    {
        /// <summary>
        /// 
        /// </summary>
        Nfs,
        /// <summary>
        /// 
        /// </summary>
        Pvc,
        /// <summary>
        /// 
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EStorageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EStorageType value)
        {
            return value switch
            {
                EStorageType.Nfs => "nfs",
                EStorageType.Pvc => "pvc",
                EStorageType.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EStorageType? ToEnum(string value)
        {
            return value switch
            {
                "nfs" => EStorageType.Nfs,
                "pvc" => EStorageType.Pvc,
                "s3" => EStorageType.S3,
                _ => null,
            };
        }
    }
}