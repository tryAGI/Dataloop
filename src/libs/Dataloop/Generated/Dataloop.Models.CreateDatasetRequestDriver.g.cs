
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Driver type of an existing driver or new driver configuration
    /// </summary>
    public enum CreateDatasetRequestDriver
    {
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
        Gcs,
        /// <summary>
        /// 
        /// </summary>
        Mongo,
        /// <summary>
        /// 
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDatasetRequestDriverExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetRequestDriver value)
        {
            return value switch
            {
                CreateDatasetRequestDriver.Azureblob => "azureblob",
                CreateDatasetRequestDriver.Fs => "fs",
                CreateDatasetRequestDriver.Gcs => "gcs",
                CreateDatasetRequestDriver.Mongo => "mongo",
                CreateDatasetRequestDriver.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetRequestDriver? ToEnum(string value)
        {
            return value switch
            {
                "azureblob" => CreateDatasetRequestDriver.Azureblob,
                "fs" => CreateDatasetRequestDriver.Fs,
                "gcs" => CreateDatasetRequestDriver.Gcs,
                "mongo" => CreateDatasetRequestDriver.Mongo,
                "s3" => CreateDatasetRequestDriver.S3,
                _ => null,
            };
        }
    }
}