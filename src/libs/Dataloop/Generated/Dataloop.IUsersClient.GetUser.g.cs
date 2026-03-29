#nullable enable

namespace Dataloop
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Returns details of the logged in user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIUser> GetUserAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}