#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="userId"></param>
        /// <param name="excludeContributors">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> IsOrgMemberRelatedToProjectsAsync(
            string orgId,
            string userId,
            bool? excludeContributors = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}