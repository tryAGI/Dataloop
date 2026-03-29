#nullable enable

namespace Dataloop
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Uninstall running application.<br/>
        /// will remove all the components belonging to the app
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIApp, object>> UninstallAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}