#nullable enable

namespace Dataloop
{
    public partial interface ICompositionsClient
    {
        /// <summary>
        /// Create a new Composition.<br/>
        /// Supply the entities in the body request to create a Composition.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIComposition> CreateAsync(

            global::Dataloop.IPostComposition request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Composition.<br/>
        /// Supply the entities in the body request to create a Composition.
        /// </summary>
        /// <param name="driverId">
        /// The user cluster driver id - defining the compute cluster the server should connect to
        /// </param>
        /// <param name="channels">
        /// Array of channels details
        /// </param>
        /// <param name="spec">
        /// An array of services
        /// </param>
        /// <param name="tasks">
        /// An array of tasks
        /// </param>
        /// <param name="packages">
        /// An array of packages
        /// </param>
        /// <param name="triggers">
        /// An array of triggers
        /// </param>
        /// <param name="projectId">
        /// The project where the composition should be install the entities
        /// </param>
        /// <param name="name">
        /// The composition name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIComposition> CreateAsync(
            string driverId,
            global::System.Collections.Generic.IList<global::Dataloop.APIServiceCompositionElement> spec,
            string projectId,
            string name,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionChannel>? channels = default,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionTask>? tasks = default,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionPackage>? packages = default,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionTrigger>? triggers = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}