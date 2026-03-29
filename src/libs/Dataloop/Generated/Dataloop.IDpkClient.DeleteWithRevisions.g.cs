#nullable enable

namespace Dataloop
{
    public partial interface IDpkClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteWithRevisionsAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}