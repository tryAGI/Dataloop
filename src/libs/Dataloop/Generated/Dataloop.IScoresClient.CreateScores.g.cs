#nullable enable

namespace Dataloop
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIScore>> CreateScoresAsync(

            global::Dataloop.CreateScoresRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scores"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIScore>> CreateScoresAsync(
            global::System.Collections.Generic.IList<global::Dataloop.Score> scores,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}