#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Models Services<br/>
        /// This will return latest 1000 models servuces
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Dataloop.ModelJoinMap2>> ModelsServicesAsync(

            global::Dataloop.ModelsServicesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Models Services<br/>
        /// This will return latest 1000 models servuces
        /// </summary>
        /// <param name="joinFilter"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Dataloop.ModelJoinMap2>> ModelsServicesAsync(
            global::Dataloop.QueryModel query,
            global::Dataloop.Dictionary? joinFilter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}