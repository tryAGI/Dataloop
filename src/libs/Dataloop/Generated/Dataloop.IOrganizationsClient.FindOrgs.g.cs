#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get all user's organizations
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Lists all the organizations in Dataloop.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be a **superuser** to use this method.<br/>
        /// # <br/>
        /// # :return: List of Organization objects<br/>
        /// # :rtype: list<br/>
        /// # <br/>
        /// # <br/>
        /// # organizations = dl.organizations.list()<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIOrg>> FindOrgsAsync(
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}