#nullable enable

namespace Dataloop
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// Get all projects for a given account
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIProject>> GetAccountProjectsAsync(
            string accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}