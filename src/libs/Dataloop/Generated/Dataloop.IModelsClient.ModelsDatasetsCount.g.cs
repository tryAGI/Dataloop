#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Models Datasets Count<br/>
        /// This will return the total dataset count that models have been assigned to
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.ModelsDatasetsCountResponse> ModelsDatasetsCountAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}