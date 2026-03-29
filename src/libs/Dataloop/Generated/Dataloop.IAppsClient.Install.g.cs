#nullable enable

namespace Dataloop
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Install a new app.<br/>
        /// Create and install a new app on the platform by given dpk name in the body request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIApp> InstallAsync(

            global::Dataloop.APIPostApp request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Install a new app.<br/>
        /// Create and install a new app on the platform by given dpk name in the body request.
        /// </summary>
        /// <param name="name">
        /// The app name
        /// </param>
        /// <param name="projectId">
        /// The project where the app should be install
        /// </param>
        /// <param name="dpkName">
        /// A unique DPK app name
        /// </param>
        /// <param name="dpkVersion">
        /// The version of the dpk app
        /// </param>
        /// <param name="scope"></param>
        /// <param name="customInstallation"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIApp> InstallAsync(
            string name,
            string projectId,
            string dpkName,
            string? dpkVersion = default,
            global::Dataloop.EAppScope? scope = default,
            global::Dataloop.CustomInstallation? customInstallation = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}