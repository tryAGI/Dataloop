#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Clone Model<br/>
        /// this will either clone or create a copy both dataset and model and create new instances of them<br/>
        /// Provide the model ID of the Model to clone from<br/>
        /// Also provide the Clone spec to clone a dataset with a filter and the model<br/>
        /// Or provide parameters to overwrite the current values in the model you want to clone
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIModel, global::Dataloop.APICommand>> CloneModelAsync(
            string id,

            global::Dataloop.AnyOf<global::Dataloop.PartialCreateModelRequest, global::Dataloop.APICopyEnvironmentSpec> request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Model<br/>
        /// this will either clone or create a copy both dataset and model and create new instances of them<br/>
        /// Provide the model ID of the Model to clone from<br/>
        /// Also provide the Clone spec to clone a dataset with a filter and the model<br/>
        /// Or provide parameters to overwrite the current values in the model you want to clone
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIModel, global::Dataloop.APICommand>> CloneModelAsync(
            string id,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}