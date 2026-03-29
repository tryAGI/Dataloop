#nullable enable

namespace Dataloop
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Change or add org to user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIUser, object>> UpdateUserOrgAsync(
            string userId,

            global::Dataloop.UpdateUserOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change or add org to user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="skipResponse"></param>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIUser, object>> UpdateUserOrgAsync(
            string userId,
            bool skipResponse,
            string orgId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}