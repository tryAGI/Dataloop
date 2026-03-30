#nullable enable

namespace Dataloop
{
    public partial interface IStorageDriversClient
    {
        /// <summary>
        /// Create a new storage driver
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create a driver on the platform using the provided payload.<br/>
        /// # <br/>
        /// # :param dict payload: The driver creation payload<br/>
        /// # :return: The created driver object<br/>
        /// # :rtype: dtlpy.entities.driver.Driver<br/>
        /// # :raises PlatformException: If the driver creation fails<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDriverConfiguration> CreateStorageDriverAsync(

            global::Dataloop.DriverPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new storage driver
        /// </summary>
        /// <param name="type"></param>
        /// <param name="creator"></param>
        /// <param name="integrationId"></param>
        /// <param name="integrationConfig"></param>
        /// <param name="metadata"></param>
        /// <param name="name"></param>
        /// <param name="payload"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDriverConfiguration> CreateStorageDriverAsync(
            global::Dataloop.DriverType type,
            string creator,
            global::Dataloop.DriverMetadata metadata,
            string name,
            global::Dataloop.AnyOf<global::Dataloop.S3DriverPayload, global::Dataloop.GcsDriverPayload, global::Dataloop.AzureBlobDriverPayload, global::Dataloop.PickFilesystemDriverConfigurationMountPath> payload,
            string? integrationId = default,
            global::Dataloop.AnyOf<global::Dataloop.S3IntegrationConfig, global::Dataloop.GcsIntegrationConfig, global::Dataloop.AzureBlobIntegrationConfig, global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath>? integrationConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}