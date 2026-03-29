#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Update Model Deployment<br/>
        /// this will allow you to update a models deployment configuration<br/>
        /// Provide the model ID, the deployment configuration and the deployment Type
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Dictionary> UpdateModelDeploymentAsync(
            string id,

            global::Dataloop.UpdateModelDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Model Deployment<br/>
        /// this will allow you to update a models deployment configuration<br/>
        /// Provide the model ID, the deployment configuration and the deployment Type
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deploymentConfig"></param>
        /// <param name="deploymentType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Dictionary> UpdateModelDeploymentAsync(
            string id,
            global::Dataloop.Dictionary deploymentConfig,
            global::Dataloop.ModelOperationTypes deploymentType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}