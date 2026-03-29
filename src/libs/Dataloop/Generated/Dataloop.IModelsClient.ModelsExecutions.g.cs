#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Models Executions<br/>
        /// This will return latest 1000 models executions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Dataloop.ModelJoinMap2>> ModelsExecutionsAsync(

            global::Dataloop.ModelsExecutionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Models Executions<br/>
        /// This will return latest 1000 models executions
        /// </summary>
        /// <param name="joinFilter"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Dataloop.ModelJoinMap2>> ModelsExecutionsAsync(
            global::Dataloop.QueryModel query,
            global::Dataloop.Dictionary? joinFilter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}