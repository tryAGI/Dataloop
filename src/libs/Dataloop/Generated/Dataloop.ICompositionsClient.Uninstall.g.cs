#nullable enable

namespace Dataloop
{
    public partial interface ICompositionsClient
    {
        /// <summary>
        /// Uninstall existing composition. move all the entities to uninstall state
        /// </summary>
        /// <param name="compositionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIComposition> UninstallAsync(
            string compositionId,

            global::Dataloop.UninstallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Uninstall existing composition. move all the entities to uninstall state
        /// </summary>
        /// <param name="compositionId"></param>
        /// <param name="value">
        /// Keep Composition Triggers Active
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIComposition> UninstallAsync(
            string compositionId,
            bool? value = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}