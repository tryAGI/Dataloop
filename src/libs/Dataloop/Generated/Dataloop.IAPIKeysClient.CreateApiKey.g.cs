#nullable enable

namespace Dataloop
{
    public partial interface IAPIKeysClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CreateApiKeyResponse> CreateApiKeyAsync(

            global::Dataloop.CreateApiKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CreateApiKeyResponse> CreateApiKeyAsync(
            string userId,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}