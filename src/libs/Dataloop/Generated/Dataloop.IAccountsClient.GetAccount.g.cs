#nullable enable

namespace Dataloop
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// Get a single account
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAccount> GetAccountAsync(
            string accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}