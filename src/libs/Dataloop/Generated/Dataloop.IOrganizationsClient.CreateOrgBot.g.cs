#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create a cross-project Developer bot for an organization.<br/>
        /// The bot becomes a Member at the org level and a Developer in every project of the org<br/>
        /// (existing and future).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIUser> CreateOrgBotAsync(
            string orgId,

            global::Dataloop.CreateOrgBotRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a cross-project Developer bot for an organization.<br/>
        /// The bot becomes a Member at the org level and a Developer in every project of the org<br/>
        /// (existing and future).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AutoSDKHttpResponse<global::Dataloop.APIUser>> CreateOrgBotAsResponseAsync(
            string orgId,

            global::Dataloop.CreateOrgBotRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a cross-project Developer bot for an organization.<br/>
        /// The bot becomes a Member at the org level and a Developer in every project of the org<br/>
        /// (existing and future).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIUser> CreateOrgBotAsync(
            string orgId,
            string? name = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}