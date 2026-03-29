
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegrationType
    {
        /// <summary>
        /// 
        /// </summary>
        AwsCross,
        /// <summary>
        /// 
        /// </summary>
        AwsSts,
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
        GcpCross,
        /// <summary>
        /// 
        /// </summary>
        GcpWorkloadIdentityFederation,
        /// <summary>
        /// 
        /// </summary>
        Gcs,
        /// <summary>
        /// 
        /// </summary>
        KeyValue,
        /// <summary>
        /// 
        /// </summary>
        Mongo,
        /// <summary>
        /// 
        /// </summary>
        PrivateRegistry,
        /// <summary>
        /// 
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationType value)
        {
            return value switch
            {
                IntegrationType.AwsCross => "aws-cross",
                IntegrationType.AwsSts => "aws-sts",
                IntegrationType.Azureblob => "azureblob",
                IntegrationType.Fs => "fs",
                IntegrationType.GcpCross => "gcp-cross",
                IntegrationType.GcpWorkloadIdentityFederation => "gcp-workload-identity-federation",
                IntegrationType.Gcs => "gcs",
                IntegrationType.KeyValue => "key_value",
                IntegrationType.Mongo => "mongo",
                IntegrationType.PrivateRegistry => "private-registry",
                IntegrationType.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "aws-cross" => IntegrationType.AwsCross,
                "aws-sts" => IntegrationType.AwsSts,
                "azureblob" => IntegrationType.Azureblob,
                "fs" => IntegrationType.Fs,
                "gcp-cross" => IntegrationType.GcpCross,
                "gcp-workload-identity-federation" => IntegrationType.GcpWorkloadIdentityFederation,
                "gcs" => IntegrationType.Gcs,
                "key_value" => IntegrationType.KeyValue,
                "mongo" => IntegrationType.Mongo,
                "private-registry" => IntegrationType.PrivateRegistry,
                "s3" => IntegrationType.S3,
                _ => null,
            };
        }
    }
}