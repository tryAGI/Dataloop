#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Model Prediction<br/>
        /// Supply the resource to perform prediction on<br/>
        /// You can also supply specific config for the deployed service
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Execution> ModelPredictionAsync(
            string id,

            global::Dataloop.ModelPredictionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Prediction<br/>
        /// Supply the resource to perform prediction on<br/>
        /// You can also supply specific config for the deployed service
        /// </summary>
        /// <param name="id"></param>
        /// <param name="config">
        /// Service Configuration
        /// </param>
        /// <param name="input">
        /// Predict input
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Execution> ModelPredictionAsync(
            string id,
            global::Dataloop.ModelPredictionRequestInput input,
            global::Dataloop.ModelPredictionRequestConfig? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}