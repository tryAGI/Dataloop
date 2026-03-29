#nullable enable

namespace Dataloop
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Deactivate an app.<br/>
        /// The server will deactivate the app and all the components belonging to the app
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIApp> DeactivateAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}