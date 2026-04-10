#nullable enable

namespace Dataloop
{
    public partial interface IOrgIntegrationsClient
    {
        /// <summary>
        /// update an existing integration configuration
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update the integration's name.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* in the organization.<br/>
        /// # <br/>
        /// # :param str new_name: new name<br/>
        /// # :param str integrations_id: integrations id<br/>
        /// # :param Integration integration: integration object<br/>
        /// # :param dict new_options: new value<br/>
        /// # :param str organization_id: organization id<br/>
        /// # :param bool reload_services: reload services associated with this integration<br/>
        /// # :return: Integration object<br/>
        /// # :rtype: dtlpy.entities.integration.Integration<br/>
        /// # <br/>
        /// # **Examples for options include**:<br/>
        /// # s3 - {key: "", secret: ""};<br/>
        /// # gcs - {key: "", secret: "", content: ""};<br/>
        /// # azureblob - {key: "", secret: "", clientId: "", tenantId: ""};<br/>
        /// # key_value - {key: "", value: ""}<br/>
        /// # aws-sts - {key: "", secret: "", roleArns: ""}<br/>
        /// # aws-cross - {roleArn: ""}<br/>
        /// # gcp-cross - {"email: "", "resourceName": ""}<br/>
        /// # <br/>
        /// # <br/>
        /// # project.integrations.update(integrations_id='integrations_id', new_options={roleArn: ""})<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIIntegration> UpdateIntegrationAsync(
            string orgId,

            global::Dataloop.IntegrationBody request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// update an existing integration configuration
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="metadata"></param>
        /// <param name="credentials"></param>
        /// <param name="name"></param>
        /// <param name="integrationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIIntegration> UpdateIntegrationAsync(
            string orgId,
            string integrationId,
            global::System.Collections.Generic.IList<global::Dataloop.IntegrationMetadataBody>? metadata = default,
            global::Dataloop.IntegrationBodyCredentials? credentials = default,
            string? name = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}