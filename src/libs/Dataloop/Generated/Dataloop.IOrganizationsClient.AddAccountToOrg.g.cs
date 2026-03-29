#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Add an account to an organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIOrg> AddAccountToOrgAsync(
            string orgId,
            string accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}