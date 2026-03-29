#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get all user's organizations
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// organizations = dl.organizations.list()<br/>
        /// # <br/>
        /// # Lists all the organizations in Dataloop.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be a **superuser** to use this method.<br/>
        /// # <br/>
        /// # :return: List of Organization objects<br/>
        /// # :rtype: list<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIOrg>> FindOrgsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}