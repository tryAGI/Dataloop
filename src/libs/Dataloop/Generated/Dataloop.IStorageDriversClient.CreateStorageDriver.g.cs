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
        /// project.drivers.create(name='driver_name',<br/>
        /// driver_type=dl.ExternalStorage.S3,<br/>
        /// integration_id='integration_id',<br/>
        /// bucket_name='bucket_name',<br/>
        /// project_id='project_id',<br/>
        /// region='ey-west-1')<br/>
        /// # <br/>
        /// # Create a storage driver.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param str name: the driver name<br/>
        /// # :param ExternalStorage driver_type: dl.ExternalStorage (Enum). For all options run: list(dl.ExsternalStorage)<br/>
        /// # :param str integration_id: the integration id<br/>
        /// # :param str bucket_name: the external bucket name<br/>
        /// # :param IntegrationType integration_type: dl.IntegrationType (Enum). For all options run: list(dl.IntegrationType)<br/>
        /// # :param str project_id: project id<br/>
        /// # :param bool allow_external_delete: true to allow deleting files from external storage when files are deleted in your Dataloop storage<br/>
        /// # :param str region: relevant only for s3 - the bucket region<br/>
        /// # :param str storage_class: relevant only for s3<br/>
        /// # :param str path: Optional. By default path is the root folder. Path is case sensitive integration<br/>
        /// # :return: driver object<br/>
        /// # :rtype: dtlpy.entities.driver.Driver<br/>
        /// # <br/>
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