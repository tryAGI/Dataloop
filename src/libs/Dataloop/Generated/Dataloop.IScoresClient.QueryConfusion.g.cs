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
        global::System.Threading.Tasks.Task<global::Dataloop.QueryConfusionResponse> QueryConfusionAsync(

            global::Dataloop.ScoreParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="score"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.QueryConfusionResponse> QueryConfusionAsync(
            global::Dataloop.ScoreParametersScore score,
            global::Dataloop.ScoreParametersOptions? options = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}