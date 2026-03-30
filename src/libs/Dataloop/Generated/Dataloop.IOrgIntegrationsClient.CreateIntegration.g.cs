#nullable enable

namespace Dataloop
{
    public partial interface IOrgIntegrationsClient
    {
        /// <summary>
        /// Create a new Integration
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create an integration between an external storage and the organization.<br/>
        /// # <br/>
        /// # **Examples for options include**:<br/>
        /// # s3 - {key: "", secret: ""};<br/>
        /// # gcs - {key: "", secret: "", content: ""};<br/>
        /// # azureblob - {key: "", secret: "", clientId: "", tenantId: ""};<br/>
        /// # key_value - {key: "", value: ""}<br/>
        /// # aws-sts - {key: "", secret: "", roleArns: ""}<br/>
        /// # aws-cross - {}<br/>
        /// # gcp-cross - {}<br/>
        /// # gcp-workload-identity-federation - {"secret": "", "content": "{}", "clientId": ""}<br/>
        /// # private-registry (ECR) - can use generate_ecr_options to generate the options<br/>
        /// # private-registry (GAR) - use generate_gar_options to generate the options<br/>
        /// # private-registry (ACR) - use generate_azure_container_registry_options to generate the options<br/>
        /// # private-registry (DockerHub) - use generate_docker_hub_options to generate the options<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* in the organization.<br/>
        /// # <br/>
        /// # :param IntegrationType integrations_type: integrations type dl.IntegrationType<br/>
        /// # :param str name: integrations name<br/>
        /// # :param dict options: dict of storage secrets<br/>
        /// # :param dict metadata: metadata<br/>
        /// # :param str organization_id: organization id<br/>
        /// # :return: success<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # project.integrations.create(integrations_type=dl.IntegrationType.S3,<br/>
        /// # name='S3Integration',<br/>
        /// # options={key: "Access key ID", secret: "Secret access key"})<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIIntegration> CreateIntegrationAsync(
            string orgId,

            global::Dataloop.CreateIntegrationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Integration
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="metadata"></param>
        /// <param name="options"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIIntegration> CreateIntegrationAsync(
            string orgId,
            global::Dataloop.Dictionary options,
            string name,
            global::Dataloop.IntegrationType2 type,
            global::Dataloop.IKeyValueMetadata? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}