#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Delete a cross-project Developer bot from an organization.<br/>
        /// Removes the bot from the org, all org projects, vault and identity providers.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="botId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteOrgBotAsync(
            string orgId,
            string botId,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a cross-project Developer bot from an organization.<br/>
        /// Removes the bot from the org, all org projects, vault and identity providers.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="botId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AutoSDKHttpResponse> DeleteOrgBotAsResponseAsync(
            string orgId,
            string botId,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}