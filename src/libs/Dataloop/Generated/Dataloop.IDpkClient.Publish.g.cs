#nullable enable

namespace Dataloop
{
    public partial interface IDpkClient
    {
        /// <summary>
        /// Publish a DPK app.<br/>
        /// Supply the dpk settings in the body request to create the object.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDpk> PublishAsync(

            global::Dataloop.APIPostDpk request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish a DPK app.<br/>
        /// Supply the dpk settings in the body request to create the object.
        /// </summary>
        /// <param name="name">
        /// The app name
        /// </param>
        /// <param name="version">
        /// The app version
        /// </param>
        /// <param name="attributes">
        /// List of attributes linked to the app
        /// </param>
        /// <param name="displayName">
        /// The display Name
        /// </param>
        /// <param name="description">
        /// description of the dpk
        /// </param>
        /// <param name="icon">
        /// icon style - should present in the ui platform
        /// </param>
        /// <param name="tags">
        /// List of tags linked to the app
        /// </param>
        /// <param name="codebase"></param>
        /// <param name="scope"></param>
        /// <param name="trusted"></param>
        /// <param name="components"></param>
        /// <param name="context"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDpk> PublishAsync(
            string name,
            global::Dataloop.Codebase codebase,
            global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>> components,
            string? version = default,
            object? attributes = default,
            string? displayName = default,
            string? description = default,
            string? icon = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Dataloop.EDpkScope? scope = default,
            bool? trusted = default,
            global::Dataloop.IAppContext? context = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}