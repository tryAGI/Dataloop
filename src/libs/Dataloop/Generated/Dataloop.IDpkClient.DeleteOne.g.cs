#nullable enable

namespace Dataloop
{
    public partial interface IDpkClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteOneAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}