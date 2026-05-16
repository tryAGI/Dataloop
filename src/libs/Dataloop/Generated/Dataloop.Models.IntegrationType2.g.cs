
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegrationType2
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
        PrivateRegistry,
        /// <summary>
        /// 
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationType2 value)
        {
            return value switch
            {
                IntegrationType2.AwsCross => "aws-cross",
                IntegrationType2.AwsSts => "aws-sts",
                IntegrationType2.Azureblob => "azureblob",
                IntegrationType2.GcpCross => "gcp-cross",
                IntegrationType2.GcpWorkloadIdentityFederation => "gcp-workload-identity-federation",
                IntegrationType2.Gcs => "gcs",
                IntegrationType2.KeyValue => "key_value",
                IntegrationType2.PrivateRegistry => "private-registry",
                IntegrationType2.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationType2? ToEnum(string value)
        {
            return value switch
            {
                "aws-cross" => IntegrationType2.AwsCross,
                "aws-sts" => IntegrationType2.AwsSts,
                "azureblob" => IntegrationType2.Azureblob,
                "gcp-cross" => IntegrationType2.GcpCross,
                "gcp-workload-identity-federation" => IntegrationType2.GcpWorkloadIdentityFederation,
                "gcs" => IntegrationType2.Gcs,
                "key_value" => IntegrationType2.KeyValue,
                "private-registry" => IntegrationType2.PrivateRegistry,
                "s3" => IntegrationType2.S3,
                _ => null,
            };
        }
    }
}