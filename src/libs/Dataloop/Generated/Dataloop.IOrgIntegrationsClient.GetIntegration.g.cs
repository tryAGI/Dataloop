#nullable enable

namespace Dataloop
{
    public partial interface IOrgIntegrationsClient
    {
        /// <summary>
        /// get a specific integration information
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="integrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// project.integrations.get(integrations_id='integrations_id')<br/>
        /// # <br/>
        /// # Get organization integrations. Use this method to access your integration and be able to use it in your code.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* in the organization.<br/>
        /// # <br/>
        /// # :param str integrations_id: integrations id<br/>
        /// # :return: Integration object<br/>
        /// # :rtype: dtlpy.entities.integration.Integration<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIIntegration> GetIntegrationAsync(
            string orgId,
            string integrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}