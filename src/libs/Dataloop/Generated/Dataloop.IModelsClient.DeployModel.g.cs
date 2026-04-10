#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Deploy Model<br/>
        /// Supply the model id to deploy it as a service<br/>
        /// You can also supply specific config for the deployed service
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeployModelAsync(
            string id,

            global::Dataloop.DeployModelRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy Model<br/>
        /// Supply the model id to deploy it as a service<br/>
        /// You can also supply specific config for the deployed service
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deployOperation"></param>
        /// <param name="serviceReference"></param>
        /// <param name="pipeline"></param>
        /// <param name="serviceConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeployModelAsync(
            string id,
            global::Dataloop.ModelOperationTypes? deployOperation = default,
            global::Dataloop.EntityReference? serviceReference = default,
            global::Dataloop.ExecutionPipelineStateReference? pipeline = default,
            global::Dataloop.Dictionary? serviceConfig = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}