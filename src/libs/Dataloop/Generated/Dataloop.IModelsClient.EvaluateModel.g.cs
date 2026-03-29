#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Evaluate Model<br/>
        /// Supply data to evaluate the model on<br/>
        /// You can also supply specific config for the deployed service
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Execution> EvaluateModelAsync(
            string id,

            global::Dataloop.EvaluateModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluate Model<br/>
        /// Supply data to evaluate the model on<br/>
        /// You can also supply specific config for the deployed service
        /// </summary>
        /// <param name="id"></param>
        /// <param name="config">
        /// Service Configuration
        /// </param>
        /// <param name="input">
        /// Evaluate input
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Execution> EvaluateModelAsync(
            string id,
            global::Dataloop.EvaluateModelRequestInput input,
            global::Dataloop.EvaluateModelRequestConfig? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}