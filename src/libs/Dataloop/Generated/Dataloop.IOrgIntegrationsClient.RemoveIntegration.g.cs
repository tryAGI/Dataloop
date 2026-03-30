#nullable enable

namespace Dataloop
{
    public partial interface IOrgIntegrationsClient
    {
        /// <summary>
        /// Delete an integration
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="integrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Delete integrations from the organization.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an organization *owner* to delete an integration.<br/>
        /// # <br/>
        /// # :param organization_id: organization id<br/>
        /// # :param str integrations_id: integrations id<br/>
        /// # :param bool sure: Are you sure you want to delete?<br/>
        /// # :param bool really: Really really sure?<br/>
        /// # :return: success<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # project.integrations.delete(integrations_id='integrations_id', sure=True, really=True)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>> RemoveIntegrationAsync(
            string orgId,
            string integrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}