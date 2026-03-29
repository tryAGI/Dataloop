#nullable enable

namespace Dataloop
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIUser> GetMeAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}