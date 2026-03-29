#nullable enable

namespace Dataloop
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Delete a Model<br/>
        /// Supply the unique id of the Model to delete
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteModelAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}