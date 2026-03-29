#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Retrieves the details of a Model.<br/>
        /// Supply the unique Model ID to fetch it's details.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIModel> GetModelAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}