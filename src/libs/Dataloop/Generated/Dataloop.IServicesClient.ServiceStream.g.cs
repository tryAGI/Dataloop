#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Service debug stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="getToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.ServiceStreamResponse> ServiceStreamAsync(
            string id,
            bool getToken,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}