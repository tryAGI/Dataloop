#nullable enable

namespace Dataloop
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Update existing app.<br/>
        /// The server will save the new app props and refresh all the components belonging to the dpk app
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIApp> UpdateAsync(
            string id,

            global::Dataloop.APIPatchApp request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update existing app.<br/>
        /// The server will save the new app props and refresh all the components belonging to the dpk app
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// The app name
        /// </param>
        /// <param name="dpkName">
        /// A unique DPK app name
        /// </param>
        /// <param name="dpkVersion">
        /// The version of the dpk app
        /// </param>
        /// <param name="trusted"></param>
        /// <param name="customInstallation"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIApp> UpdateAsync(
            string id,
            string name,
            string dpkName,
            string? dpkVersion = default,
            bool? trusted = default,
            global::Dataloop.CustomInstallation? customInstallation = default,
            global::Dataloop.CompositionStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}