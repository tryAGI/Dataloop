
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DriverType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureDatalakeGen2,
        /// <summary>
        /// 
        /// </summary>
        Azureblob,
        /// <summary>
        /// 
        /// </summary>
        Fs,
        /// <summary>
        /// 
        /// </summary>
        FsExternal,
        /// <summary>
        /// 
        /// </summary>
        Gcs,
        /// <summary>
        /// 
        /// </summary>
        InternalGcs,
        /// <summary>
        /// 
        /// </summary>
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        Mongo,
        /// <summary>
        /// 
        /// </summary>
        Noop,
        /// <summary>
        /// 
        /// </summary>
        Proxy,
        /// <summary>
        /// 
        /// </summary>
        S3,
        /// <summary>
        /// 
        /// </summary>
        S3customerInternal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DriverTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DriverType value)
        {
            return value switch
            {
                DriverType.AzureDatalakeGen2 => "azureDatalakeGen2",
                DriverType.Azureblob => "azureblob",
                DriverType.Fs => "fs",
                DriverType.FsExternal => "fsExternal",
                DriverType.Gcs => "gcs",
                DriverType.InternalGcs => "internalGcs",
                DriverType.Invalid => "invalid",
                DriverType.Mongo => "mongo",
                DriverType.Noop => "noop",
                DriverType.Proxy => "proxy",
                DriverType.S3 => "s3",
                DriverType.S3customerInternal => "s3customerInternal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DriverType? ToEnum(string value)
        {
            return value switch
            {
                "azureDatalakeGen2" => DriverType.AzureDatalakeGen2,
                "azureblob" => DriverType.Azureblob,
                "fs" => DriverType.Fs,
                "fsExternal" => DriverType.FsExternal,
                "gcs" => DriverType.Gcs,
                "internalGcs" => DriverType.InternalGcs,
                "invalid" => DriverType.Invalid,
                "mongo" => DriverType.Mongo,
                "noop" => DriverType.Noop,
                "proxy" => DriverType.Proxy,
                "s3" => DriverType.S3,
                "s3customerInternal" => DriverType.S3customerInternal,
                _ => null,
            };
        }
    }
}