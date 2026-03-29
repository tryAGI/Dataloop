#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Execution> ExtractItemFeaturesAsync(
            string id,

            global::Dataloop.ExtractItemFeaturesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="config">
        /// Service Configuration
        /// </param>
        /// <param name="input">
        /// embed input
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Execution> ExtractItemFeaturesAsync(
            string id,
            global::Dataloop.ExtractItemFeaturesRequestInput input,
            global::Dataloop.ExtractItemFeaturesRequestConfig? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}