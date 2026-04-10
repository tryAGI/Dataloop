#nullable enable

namespace Dataloop
{
    public partial interface IOrgIntegrationsClient
    {
        /// <summary>
        /// Get all organization's integrations
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # List all the organization's integrations with external storage.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* in the organization.<br/>
        /// # <br/>
        /// # :param bool only_available: if True list only the available integrations.<br/>
        /// # :param str organization_id: organization id<br/>
        /// # :return: groups list<br/>
        /// # :rtype: list<br/>
        /// # <br/>
        /// # <br/>
        /// # project.integrations.list(only_available=True)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>> GetOrgIntegrationsAsync(
            string orgId,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}