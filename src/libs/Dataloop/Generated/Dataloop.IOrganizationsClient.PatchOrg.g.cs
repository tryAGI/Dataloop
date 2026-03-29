#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Change an organization's name
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIOrg> PatchOrgAsync(
            string orgId,

            global::Dataloop.PatchOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change an organization's name
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIOrg> PatchOrgAsync(
            string orgId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}