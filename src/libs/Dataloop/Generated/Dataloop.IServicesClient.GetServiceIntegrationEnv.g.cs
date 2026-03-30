#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Returns only the env key-values for the integrations listed in service.integrations.<br/>
        /// Callable by service bot or sudo with Piper auth (direct).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.GetServiceIntegrationEnvResponse> GetServiceIntegrationEnvAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}