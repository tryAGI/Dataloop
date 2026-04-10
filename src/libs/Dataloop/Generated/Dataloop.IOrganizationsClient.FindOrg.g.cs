#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Find an organization by id
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get Organization object to be able to use it in your code.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be a **superuser** to use this method.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: organization_name or organization_id.<br/>
        /// # <br/>
        /// # :param str organization_id: optional - search by id<br/>
        /// # :param str organization_name: optional - search by name<br/>
        /// # :param fetch: optional - fetch entity from platform, default taken from cookie<br/>
        /// # :return: Organization object<br/>
        /// # :rtype: dtlpy.entities.organization.Organization<br/>
        /// # <br/>
        /// # <br/>
        /// # org = dl.organizations.get(organization_id='organization_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIOrg> FindOrgAsync(
            string orgId,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}