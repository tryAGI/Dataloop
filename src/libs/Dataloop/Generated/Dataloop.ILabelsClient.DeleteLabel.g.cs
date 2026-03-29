#nullable enable

namespace Dataloop
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ontologyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteLabelAsync(
            string id,
            string ontologyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}