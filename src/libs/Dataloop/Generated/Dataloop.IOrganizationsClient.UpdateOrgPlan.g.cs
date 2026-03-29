#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Update an organization's plan
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIOrg> UpdateOrgPlanAsync(
            string orgId,

            global::Dataloop.UpdateOrgPlanRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an organization's plan
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="plan"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIOrg> UpdateOrgPlanAsync(
            string orgId,
            string plan,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}