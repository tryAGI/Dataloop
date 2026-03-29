#nullable enable

namespace Dataloop
{
    public partial interface IAPIKeysClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIApiKey> GetApiKeyAsync(
            string keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}