#nullable enable

namespace Dataloop
{
    public partial interface IServiceDriversClient
    {
        /// <summary>
        /// Get Service Driver.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="archived">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIServiceDriver> GetAsync(
            string id,
            bool? archived = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}