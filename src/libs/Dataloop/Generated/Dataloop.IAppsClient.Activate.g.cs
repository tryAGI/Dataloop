#nullable enable

namespace Dataloop
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Activate an app.<br/>
        /// The server will activate the app and all the components belonging to the app
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIApp> ActivateAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}