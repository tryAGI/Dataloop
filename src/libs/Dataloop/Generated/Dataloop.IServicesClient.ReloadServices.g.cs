#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Reload Services.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> ReloadServicesAsync(

            global::Dataloop.Dictionary request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reload Services.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> ReloadServicesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}