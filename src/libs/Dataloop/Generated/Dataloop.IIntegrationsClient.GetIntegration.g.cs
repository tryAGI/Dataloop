#nullable enable

namespace Dataloop
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// get a specific integration information
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIIntegration> GetIntegrationAsync(
            string integrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}