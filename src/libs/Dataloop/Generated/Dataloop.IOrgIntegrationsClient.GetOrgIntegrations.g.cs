#nullable enable

namespace Dataloop
{
    public partial interface IOrgIntegrationsClient
    {
        /// <summary>
        /// Get all organization's integrations
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// project.integrations.list(only_available=True)<br/>
        /// # <br/>
        /// # List all the organization's integrations with external storage.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* in the organization.<br/>
        /// # <br/>
        /// # :param bool only_available: if True list only the available integrations.<br/>
        /// # :return: groups list<br/>
        /// # :rtype: list<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>> GetOrgIntegrationsAsync(
            string orgId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}