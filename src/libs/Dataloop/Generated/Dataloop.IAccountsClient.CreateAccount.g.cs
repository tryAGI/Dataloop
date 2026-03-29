#nullable enable

namespace Dataloop
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// Create a new account for a given organization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAccount> CreateAccountAsync(

            global::Dataloop.CreateAccountRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new account for a given organization
        /// </summary>
        /// <param name="name"></param>
        /// <param name="createdBy"></param>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAccount> CreateAccountAsync(
            string name,
            string createdBy,
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}